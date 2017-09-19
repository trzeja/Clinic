using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;
using BizzLayer.Facades;
using System.Globalization;

namespace Clinic
{
    public partial class Doctor : Form
    {
        private int idDoctor;
        private int idPatient = 0;
        
        public Doctor(int idDoctor)
        {
            InitializeComponent();
            Initialize(idDoctor);
        }

        private void Initialize(int idDoctor)
        {
            this.idDoctor = idDoctor;
            doctorDateTimePickerExecDate.Checked = true;
            //doctorVisitStateComboBox.SelectedIndex = doctorVisitStateComboBox.FindStringExact("REG");
            int index = doctorVisitStateComboBox.Items.IndexOf("REG");
            doctorVisitStateComboBox.SelectedItem = doctorVisitStateComboBox.Items[index];
            this.doctorPatientNameTextBox.Text = "All patients";
            Visit visit = new Visit();
            visit.registration_date = doctorDateTimePickerExecDate.Value;
            visit.state = doctorVisitStateComboBox.SelectedItem.ToString();
            visit.id_doctor = idDoctor;
            this.dataGridView1.DataSource = DoctorFacade.GetPatientsWithAdresses(idDoctor,idPatient,visit);
            //this.dataGridView1.DataSource = DoctorFacade.GetVisitsFromToday(idDoctor, doctorDateTimePickerExecDate.Value);
            this.dataGridView1.Columns[0].HeaderText = "Patient's first name";
            this.dataGridView1.Columns[1].HeaderText = "Patient's last name";
            this.dataGridView1.Columns[3].HeaderText = "State of visit";
            this.dataGridView1.Columns[4].HeaderText = "Registration date";
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void doctorAllPatientsButton_Click(object sender, EventArgs e)
        {
            idPatient = 0;
            this.doctorPatientNameTextBox.Text = "All patients";
        }

        private void doctorSearchButton_Click(object sender, EventArgs e)
        {
            
            //Patient patientSearchCriteria = new Patient();
            Visit visit = new Visit();
            visit.id_patient = idPatient;
            if (this.doctorVisitStateComboBox.SelectedItem != null)
            {
                visit.state = this.doctorVisitStateComboBox.SelectedItem.ToString();                    
            }

            if (doctorDateTimePickerExecDate.Checked == true)
            {
                visit.registration_date = doctorDateTimePickerExecDate.Value;
            }
            else
            {
                //na razie nic lepszego do glowy mi nie przychodzi, chyba ze druga funkcja w doctorFacade // MW
                DateTime loadedDate = DateTime.ParseExact("01.01.1754 00:00:00", "dd.MM.yyyy HH:mm:ss",
                                        System.Globalization.CultureInfo.InvariantCulture);
                visit.registration_date = loadedDate;
            }

            this.dataGridView1.DataSource = DoctorFacade.GetPatientsWithAdresses(idDoctor,idPatient, visit);
            this.dataGridView1.Columns[0].HeaderText = "Patient's first name";
            this.dataGridView1.Columns[1].HeaderText = "Patient's last name";
            this.dataGridView1.Columns[3].HeaderText = "State of visit";
            this.dataGridView1.Columns[4].HeaderText = "Registration date";
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //force select first row
            if (dataGridView1.Rows.Count >= 1) dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
        }

        private void doctorSelectVisitbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.SelectedCells.Count == 0)
            {
                //MessageBox.Show("No visit selected", "Error");
                MessageBox.Show("No visit selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                //MessageBox.Show("Selected too many visits, please select just one", "Error");
                MessageBox.Show("Selected too many visits ! \nPlease select just one...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int visitIndex = dataGridView1.CurrentRow.Index;
                int idVisit = Int32.Parse(dataGridView1.Rows[visitIndex].Cells[5].Value.ToString());
                Patient patient = DoctorFacade.GetPatientByVisit(idVisit);
                //tu musimy wyciagnac wszstko z wizyty
                DoctorVisitViewForm doctorViewVisit = new DoctorVisitViewForm(patient, idVisit);
                doctorViewVisit.ShowDialog(this);
                Visit visit = new Visit();
                visit.id_patient = idPatient;
                if (this.doctorVisitStateComboBox.SelectedItem != null)
                {
                    visit.state = this.doctorVisitStateComboBox.SelectedItem.ToString();
                }

                if (doctorDateTimePickerExecDate.Checked == true)
                {
                    visit.registration_date = doctorDateTimePickerExecDate.Value;
                }
                else
                {
                    DateTime loadedDate = DateTime.ParseExact("01.01.1754 00:00:00", "dd.MM.yyyy HH:mm:ss",
                                            System.Globalization.CultureInfo.InvariantCulture);
                    visit.registration_date = loadedDate;
                }
                this.dataGridView1.DataSource = DoctorFacade.GetPatientsWithAdresses(idDoctor, idPatient, visit);
            }
        }

        private void doctorFindPatientButton_Click(object sender, EventArgs e)
        {
            SelectPersonForm doctorSelectPatient = new SelectPersonForm();
            doctorSelectPatient.setRegistrarAddButtonEnableDisable(false);
            doctorSelectPatient.ShowDialog(this);


            idPatient = 0;
            try
            {
                idPatient = doctorSelectPatient.getID();
                if (idPatient<0) throw new System.ArgumentException("Invalid index", "original");
                Patient patientSearchCriteria;
                patientSearchCriteria = new Patient();
                patientSearchCriteria.id_patient = idPatient;
                this.doctorPatientNameTextBox.Text = doctorSelectPatient.getLname();

            }

            catch (Exception ex)
            {
                // NIE RUSZAć !!
                //MessageBox.Show("Person not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                idPatient = -1;
                this.doctorPatientNameTextBox.Text = "All patients";
            }
        }
    }
}

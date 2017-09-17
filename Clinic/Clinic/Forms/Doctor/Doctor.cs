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
        Patient p;
        private List<string> dataFromGrid = new List<string>();
        // private enum index { ID = 0, FNAME, LNAME, PESEL, PLACE, STREET, ZIPCODE, HOUSE, FLAT };
        public Doctor()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            p = new Patient();

        }

        private void doctorSearchButton_Click(object sender, EventArgs e)
        {
            //this.Controls.Add(this.dataGridViewDoctor);

            //Patient mockPatient = new Patient();
            //mockPatient.id_patient = 1;

            //Visit visitSearchCriteria = new Visit();
            //visitSearchCriteria.id_patient = mockPatient.id_patient;
            //visitSearchCriteria.state = doctorVisitStateComboBox.Text;
            //visitSearchCriteria.registration_date = doctorDateTimePickerExecDate.Value;

            //VisitFacade.GetPatientsVisits(visitSearchCriteria);

            // this.Controls.Add(this.dataGridViewDoctor)
            //GetPatientsWithAdresses()
            Patient patientSearchCriteria = new Patient();
            Visit visit = new Visit();



            if (id_patient != 0)
            {
                patientSearchCriteria.id_patient = id_patient;


                visit.id_patient = id_patient;
                if (this.doctorVisitStateComboBox.SelectedItem != null)
                {
                    string visitState = this.doctorVisitStateComboBox.SelectedItem.ToString();                    
                }
                if (doctorDateTimePickerExecDate.Checked == true)
                {
                    //DateTime loadedDate = DateTime.ParseExact(doctorDateTimePickerExecDate.Value.ToString(), "dd.MM.yyyy HH:mm:ss",
                    //                        System.Globalization.CultureInfo.InvariantCulture);
                    //visit.registration_date = loadedDate;
                    visit.registration_date = doctorDateTimePickerExecDate.Value;
                }

                else
                {

                    //na razie nic lepszego do glowy mi nie przychodzi, chyba ze druga funkcja w doctorFacade // MW
                    DateTime loadedDate = DateTime.ParseExact("01.01.1754 00:00:00", "dd.MM.yyyy HH:mm:ss",
                                            System.Globalization.CultureInfo.InvariantCulture);
                    visit.registration_date = loadedDate;
                    // visit.registration_date = DateTime.MinValue;
                }

                this.dataGridView1.DataSource = DoctorFacade.GetPatientsWithAdresses(patientSearchCriteria, visit);
                this.dataGridView1.Columns[0].HeaderText = "Patient's first name";
                this.dataGridView1.Columns[1].HeaderText = "Patient's last name";
                this.dataGridView1.Columns[3].HeaderText = "State of visit";
                this.dataGridView1.Columns[4].HeaderText = "Registration date";
                // this.dataGridView1.Columns[0].Name = "Patient's first name";
                this.dataGridView1.Columns[5].Visible = false;
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                //MessageBox.Show("Invalid Data", "Error");
                MessageBox.Show("Invalid Data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            }
        }

        private void doctorFindPatientButton_Click(object sender, EventArgs e)
        {
            SelectPersonForm doctorSelectPatient = new SelectPersonForm();
            doctorSelectPatient.setRegistrarAddButtonEnableDisable(false);
            doctorSelectPatient.ShowDialog(this);


            id_patient = 0;
            try
            {
                Int32.TryParse(doctorSelectPatient.getID(), out id_patient);
                Patient patientSearchCriteria;
                patientSearchCriteria = new Patient();
                patientSearchCriteria.id_patient = id_patient;
                this.doctorPatientNameTextBox.Text = doctorSelectPatient.getLname();

            }

            catch (Exception ex)
            {
                //MessageBox.Show("Check again patient", "Error");
                MessageBox.Show("Check again patient !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // dataGridView1.DataSource = DoctorFacade.GetPatientsWithAdresses(patientSearchCriteria);
        }
        private int id_patient = 0;
        
    }
}

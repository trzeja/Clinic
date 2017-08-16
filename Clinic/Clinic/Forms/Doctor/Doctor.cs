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
                visit.state = this.doctorVisitStateComboBox.SelectedItem.ToString();
                if (doctorDateTimePickerExecDate.Checked == true)
                {
                    DateTime loadedDate = DateTime.ParseExact(doctorDateTimePickerExecDate.Value.ToString(), "dd.MM.yyyy HH:mm:ss",
                                            System.Globalization.CultureInfo.InvariantCulture);
                    visit.registration_date = loadedDate;
                }

                else
                {

                    //na razie nic lepszego do glowy mi nie przychodzi, chyba ze druga funkcja w doctorFacade // MW
                    DateTime loadedDate = DateTime.ParseExact("01.01.1754 00:00:00", "dd.MM.yyyy HH:mm:ss",
                                            System.Globalization.CultureInfo.InvariantCulture);
                    visit.registration_date = loadedDate;

                }

                this.dataGridView1.DataSource = DoctorFacade.GetPatientsWithAdresses(patientSearchCriteria, visit);
            }
            else
            {
                MessageBox.Show("Invalid Data", "Error");
            }
        }

        private void doctorSelectVisitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string tmpID;
                int curRowIndex = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.Rows[curRowIndex].Cells[5].Value == null) throw new Exception();

                tmpID = dataGridView1.Rows[curRowIndex].Cells[5].Value.ToString();
                int id = Int32.Parse(tmpID);
                if (id == 0) throw new Exception();
                DoctorVisitViewForm doctorViewVisit = new DoctorVisitViewForm(id);
                doctorViewVisit.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You didn't select visit!", "Error");
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
                MessageBox.Show("Check again patient", "Error");
            }

            // dataGridView1.DataSource = DoctorFacade.GetPatientsWithAdresses(patientSearchCriteria);
        }
        private int id_patient = 0;
    }
}

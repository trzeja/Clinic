using BizzLayer;
using Clinic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            Initialize();
            

        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet1.Visit' table. You can move, or remove it, as needed.
            this.visitTableAdapter.Fill(this.clinicDataSet1.Visit);

        }

        private void resgistrarAddVisitButton_Click(object sender, EventArgs e)
        {
            RegistrarAddFrom registrarAddFrom = new RegistrarAddFrom();
            registrarAddFrom.setModifyTrueAddFalse(false);
            registrarAddFrom.ShowDialog(this);
           



        }

 

        private void Initialize()
        {
            //this.registrarTextBoxPatient.ReadOnly = true;
            //this.registrarTextBoxDoctor.ReadOnly = true;

           



        }

        private void registrarSearchButton_Click(object sender, EventArgs e)
        {
            this.Height = 600;
            this.dataGridViewRegistrar.Size = new System.Drawing.Size(733, 300);
            //Patient patientSearchCriteria;
            //patientSearchCriteria = new Patient();
            //patientSearchCriteria.fname = registrarTextBoxPatientFName.Text;
            //patientSearchCriteria.lname = registrarTextBoxPatientLName.Text;
            //IQueryable<Patient> patientResult = PatientFacade.GetPatient(patientSearchCriteria);

            //User userDoctorSearchCriteria;
            //userDoctorSearchCriteria = new User();
            //userDoctorSearchCriteria.fname = registrarTextBoxDoctorFName.Text;
            //userDoctorSearchCriteria.lname = registrarTextBoxDoctorLName.Text;
            //IQueryable<User> doctorUserResult = UserFacade.GetUser(userDoctorSearchCriteria);

            //BizzLayer.Doctor doctorSearchCriteria;
            //doctorSearchCriteria = new BizzLayer.Doctor();
            //doctorSearchCriteria.user_name = doctorUserResult.FirstOrDefault().user_name;
            //IQueryable<BizzLayer.Doctor> doctorResult = DoctorFacade.GetDoctor(doctorSearchCriteria);


            //Visit visitSearchCriteria; ;
            //visitSearchCriteria = new Visit();
            //visitSearchCriteria.state = registrarStateComboBox.Text;
            //visitSearchCriteria.registration_date = dataTimePickerRegDate.Value;
            ////visitSearchCriteria.id_patient = patientResult.FirstOrDefault().id_patient;
            ////visitSearchCriteria.id_doctor = doctorResult.FirstOrDefault().id_doc;


            //// ładowanie obiektu dataGridView
            //dataGridViewRegistrar.Columns.Clear();
            //// dataGridView1.AutoGenerateColumns = true;
            //dataGridViewRegistrar.DataSource = VisitFacade.GetVisit(visitSearchCriteria);
            //dataGridViewRegistrar.Columns[0].Visible = false;//id visit
            //dataGridViewRegistrar.Columns[1].Visible = false;//description
            //dataGridViewRegistrar.Columns[2].Visible = false;//diagnosis
            //dataGridViewRegistrar.Columns[6].Visible = false;//id patient
            //dataGridViewRegistrar.Columns[7].Visible = false;//id reg
            //dataGridViewRegistrar.Columns[8].Visible = false;//id doc
            ////dataGridViewRegistrar.
            ////dataGridViewRegistrar.Columns[4].Visible = false;//adres


            registrarVisitView visitSearchCriteria;
            visitSearchCriteria = new registrarVisitView();
            visitSearchCriteria.doctorFname= registrarTextBoxDoctorFName.Text;
            visitSearchCriteria.doctorLname = registrarTextBoxDoctorLName.Text;
            visitSearchCriteria.patientFname = registrarTextBoxPatientFName.Text;
            visitSearchCriteria.patientLname = registrarTextBoxPatientLName.Text;            
            visitSearchCriteria.state = registrarStateComboBox.Text;
            if (dataTimePickerRegDate.Checked) visitSearchCriteria.registration_date = dataTimePickerRegDate.Value;
            else visitSearchCriteria.registration_date = DateTime.MinValue;

            IQueryable<registrarVisitView> visits= RegistrationFacade.GetVisits(visitSearchCriteria);
            dataGridViewRegistrar.DataSource = RegistrationFacade.GetVisits(visitSearchCriteria);
            dataGridViewRegistrar.Columns[0].Visible = false;
            dataGridViewRegistrar.Columns[1].HeaderText = "Patient first name";
            dataGridViewRegistrar.Columns[2].HeaderText = "Patient last name";
            dataGridViewRegistrar.Columns[3].HeaderText = "Doctor first name";
            dataGridViewRegistrar.Columns[4].HeaderText = "Doctor last name";
            dataGridViewRegistrar.Columns[5].HeaderText = "State";
            dataGridViewRegistrar.Columns[6].HeaderText = "Registration date";
            dataGridViewRegistrar.Columns[7].HeaderText = "Cancel date";
        }

        private void registrarSelectDoctorButton_Click(object sender, EventArgs e)
        {
            RegistrarAddFrom registrarmodifyVisit= new RegistrarAddFrom();
            registrarmodifyVisit.setModifyTrueAddFalse(true);
            registrarmodifyVisit.ShowDialog(this);

        }
       

        private void registrarSelectPatientButton_Click(object sender, EventArgs e)
        {
            SelectPersonForm registrarSelectPatient = new SelectPersonForm();
            registrarSelectPatient.setRegistrarAddButtonEnableDisable(false);
            registrarSelectPatient.ShowDialog(this);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void registrarModifyPatientButton_Click(object sender, EventArgs e)
        {

            SelectPersonForm registrarSelectPatient = new SelectPersonForm("Modify", true);
            registrarSelectPatient.ShowDialog(this);
        }
    }
}

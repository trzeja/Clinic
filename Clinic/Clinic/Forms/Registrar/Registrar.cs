using BizzLayer;
using BizzLayer.Facades;
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
            RegistrarAddModifyForm registrarAddFrom = new RegistrarAddModifyForm();
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
            registrarVisitView visitSearchCriteria = new registrarVisitView();

            visitSearchCriteria.doctorFname = registrarTextBoxDoctorFName.Text;
            visitSearchCriteria.doctorLname = registrarTextBoxDoctorLName.Text;
            visitSearchCriteria.patientFname = registrarTextBoxPatientFName.Text;
            visitSearchCriteria.patientLname = registrarTextBoxPatientLName.Text;
            visitSearchCriteria.state = registrarStateComboBox.Text;

            if (dataTimePickerRegDate.Checked)
            {
                visitSearchCriteria.registration_date = dataTimePickerRegDate.Value;
            }
            else
            {
                visitSearchCriteria.registration_date = DateTime.MinValue;
            }

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

        private void registrarModifyVisitButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegistrar.CurrentRow != null)
            {
                int visitIndex = dataGridViewRegistrar.CurrentRow.Index;
                int id_visit = (int)dataGridViewRegistrar.Rows[visitIndex].Cells[0].Value;
                
                RegistrarAddModifyForm registrarModifyVisit = new RegistrarAddModifyForm(id_visit);
                registrarModifyVisit.setModifyTrueAddFalse(true);
                registrarModifyVisit.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Please select visit first");
            }
        }

        private void registrarSelectPatientButton_Click(object sender, EventArgs e)
        {
            SelectPersonForm registrarSelectPatient = new SelectPersonForm();
            registrarSelectPatient.setRegistrarAddButtonEnableDisable(false);
            registrarSelectPatient.ShowDialog(this);

        }

        private void registrarModifyPatientButton_Click(object sender, EventArgs e)
        {

            SelectPersonForm registrarSelectPatient = new SelectPersonForm("Modify", true);
            registrarSelectPatient.ShowDialog(this);
        }

        private void Registrar_Resize(object sender, EventArgs e)
        {
            dataGridViewRegistrar.Height = 131 + this.Height - 394;
        }
    }
}

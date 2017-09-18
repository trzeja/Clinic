using BizzLayer;
using BizzLayer.Facades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
namespace Clinic
{
  
    public partial class RegistrarAddModifyForm : Form
    {
        private bool modifyTrueAddFalse;
        public RegistrarAddModifyForm(int? idVisit = null)
        {
            InitializeComponent();
            Initialize(idVisit);
        }
        
        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDRegistration

        //private void registrarTextBoxIDRegistration_Enter(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxIDRegistration.Text == "ID Registration")
        //    {
        //        registrarTextBoxIDRegistration.Text = "";
        //        registrarTextBoxIDRegistration.ForeColor = SystemColors.WindowText;
        //    }
        //}

        //private void registrarTextBoxIDRegistration_Leave(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxIDRegistration.Text.Length == 0)
        //    {
        //        registrarTextBoxIDRegistration.Text = "ID Registration";
        //        registrarTextBoxIDRegistration.ForeColor = SystemColors.GrayText;
        //    }
        //}
             

        private void Initialize(int? idVisit = null)
        {
            this.registrarTextBoxPatientName.ReadOnly = true;
            this.registrarTextBoxDoctor.ReadOnly = true;

            if (idVisit != null)
            {
                registrarVisitView visitSearchCriteria = new registrarVisitView();
                visitSearchCriteria.id_visit = (int)idVisit;
                var visit = RegistrationFacade.GetVisits(visitSearchCriteria).FirstOrDefault();

                this.dataTimePickerRegDate.Value = visit.registration_date;
                this.registrarTextBoxPatientName.Text = visit.patientLname;
                this.registrarTextBoxDoctor.Text = visit.doctorLname;
                this.registrarStateComboBox.SelectedIndex = this.registrarStateComboBox.FindStringExact(visit.state);
            }
        }

        
        private void registrarApproveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarTextBoxPatient_TextChanged(object sender, EventArgs e)
        {

        }

        public void setModifyTrueAddFalse(bool set)
        {
            //set==true --> Modify form acive
            modifyTrueAddFalse = set;
            this.registrarSelectPatientButton.Visible = !set;
            this.registrarSelectDoctorButton.Visible = true;
            this.registrarStateComboBox.Visible = set;
            this.stateLabel.Visible = set;
            if (set == false)
            {
                this.Text = "Add";
            }            
        }

        private void RegistrarAddFrom_Load(object sender, EventArgs e)
        {

        }

        private void registrarSelectPatientButton_Click(object sender, EventArgs e)
        {
           
            if (modifyTrueAddFalse == true) return; // modify form active!
            SelectPersonForm registrarSelectPatient = new SelectPersonForm();
            registrarSelectPatient.setRegistrarAddButtonEnableDisable(true);
            registrarSelectPatient.ShowDialog(this);

        }

        private void registrarSelectDoctorButton_Click(object sender, EventArgs e)
        {
           
            SelectPersonForm registrarSelectDoctor = new SelectPersonForm();
            registrarSelectDoctor.setRegistrarAddButtonEnableDisable(false);
            registrarSelectDoctor.ShowDialog(this);

        }
    }
}

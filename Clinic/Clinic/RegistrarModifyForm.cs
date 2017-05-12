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
    public partial class RegistrarAddFrom : Form
    {
        public RegistrarAddFrom()
        {
            InitializeComponent();
            Initialize();
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

      

        private void Initialize()
        {

            this.textBoxState.ReadOnly = true;
            this.textBoxState.BackColor = Color.White;



        }



        private void registrarApproveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarTextBoxPatient_TextChanged(object sender, EventArgs e)
        {

        }

        public void setRegistrarCancelVisitButtonEnableDisable(bool set)
        {
            //set==true --> Modify form acive
            this.registrarCancelVisitButton.Enabled = set;
            this.registrarCancelVisitButton.Visible = set;
            this.registrarSelectPatientButton.Visible = !set;
            this.registrarSelectDoctorButton.Visible = !set;
            
           
        }


       

        private void RegistrarAddFrom_Load(object sender, EventArgs e)
        {

        }

        private void registrarSelectPatientButton_Click(object sender, EventArgs e)
        {
           
            if (this.registrarCancelVisitButton.Enabled == true) return; // modify form active!
            SelectPersonForm registrarSelectPatient = new SelectPersonForm();
            registrarSelectPatient.setRegistrarAddButtonEnableDisable(true);
            registrarSelectPatient.ShowDialog(this);

        }

        private void registrarSelectDoctorButton_Click(object sender, EventArgs e)
        {
            if (this.registrarCancelVisitButton.Enabled == true) return; // modify form active!
            SelectPersonForm registrarSelectDoctor = new SelectPersonForm();
            registrarSelectDoctor.setRegistrarAddButtonEnableDisable(false);
            registrarSelectDoctor.ShowDialog(this);

        }
    }
}

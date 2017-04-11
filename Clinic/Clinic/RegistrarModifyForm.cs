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

        //registrarTextBoxIDVisit
        //private void registrarTextBoxIDVisit_Leave(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxIDVisit.Text.Length == 0)
        //    {
        //        registrarTextBoxIDVisit.Text = "ID Visit";
        //        registrarTextBoxIDVisit.ForeColor = SystemColors.GrayText;
        //    }
        //}

        //private void registrarTextBoxIDVisit_Enter(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxIDVisit.Text == "ID Visit")
        //    {
        //        registrarTextBoxIDVisit.Text = "";
        //        registrarTextBoxIDVisit.ForeColor = SystemColors.WindowText;
        //    }
        //}
        ///*///////////////////////////////////////////////////////////////////////*/
        ////registrarTextBoxDescription
        //private void registrarTextBoxDescription_Leave(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxDescription.Text.Length == 0)
        //    {
        //        registrarTextBoxDescription.Text = "Description";
        //        registrarTextBoxDescription.ForeColor = SystemColors.GrayText;
        //    }
        //}


        //private void registrarTextBoxDescription_Enter(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxDescription.Text == "Description")
        //    {
        //        registrarTextBoxDescription.Text = "";
        //        registrarTextBoxDescription.ForeColor = SystemColors.WindowText;
        //    }
        //}
        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxDiagnosis
        //private void registrarTextBoxDiagnosis_Enter(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxDiagnosis.Text == "Diagnosis")
        //    {
        //        registrarTextBoxDiagnosis.Text = "";
        //        registrarTextBoxDiagnosis.ForeColor = SystemColors.WindowText;
        //    }
        //}


        //private void registrarTextBoxDiagnosis_Leave(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxDiagnosis.Text.Length == 0)
        //    {
        //        registrarTextBoxDiagnosis.Text = "Diagnosis";
        //        registrarTextBoxDiagnosis.ForeColor = SystemColors.GrayText;
        //    }
        //}

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxState
        //private void registrarTextBoxState_Enter(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxState.Text == "State")
        //    {
        //        registrarTextBoxState.Text = "";
        //        registrarTextBoxState.ForeColor = SystemColors.WindowText;
        //    }
        //}

        //private void registrarTextBoxState_Leave(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxState.Text.Length == 0)
        //    {
        //        registrarTextBoxState.Text = "State";
        //        registrarTextBoxState.ForeColor = SystemColors.GrayText;
        //    }
        //}
        /*///////////////////////////////////////////////////////////////////////*/


        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxRegDate
        //private void registrarTextBoxRegDate_Enter(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxRegDate.Text == "Registration date")
        //    {
        //        registrarTextBoxRegDate.Text = "";
        //        registrarTextBoxRegDate.ForeColor = SystemColors.WindowText;
        //    }
        //}

        //private void registrarTextBoxRegDate_Leave(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxRegDate.Text.Length == 0)
        //    {
        //        registrarTextBoxRegDate.Text = "Registration date";
        //        registrarTextBoxRegDate.ForeColor = SystemColors.GrayText;
        //    }
        //}
        ///*///////////////////////////////////////////////////////////////////////*/
        ////registrarTextBoxExCancelDate

        //private void registrarTextBoxExCancelDate_Enter(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxExCancelDate.Text == "Execution, cancel date")
        //    {
        //        registrarTextBoxExCancelDate.Text = "";
        //        registrarTextBoxExCancelDate.ForeColor = SystemColors.WindowText;
        //    }
        //}

        //private void registrarTextBoxExCancelDate_Leave(object sender, EventArgs e)
        //{
        //    if (registrarTextBoxExCancelDate.Text.Length == 0)
        //    {
        //        registrarTextBoxExCancelDate.Text = "Execution, cancel date";
        //        registrarTextBoxExCancelDate.ForeColor = SystemColors.GrayText;
        //    }
        //}

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDPatient

        private void registrarTextBoxIDPatient_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxPatient.Text == "ID Patient")
            {
                registrarTextBoxPatient.Text = "";
                registrarTextBoxPatient.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxIDPatient_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxPatient.Text.Length == 0)
            {
                registrarTextBoxPatient.Text = "ID Patient";
                registrarTextBoxPatient.ForeColor = SystemColors.GrayText;
            }
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

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDDoctor

        private void registrarTextBoxIDDoctor_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxDoctor.Text == "ID Doctor")
            {
                registrarTextBoxDoctor.Text = "";
                registrarTextBoxDoctor.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxIDDoctor_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxDoctor.Text.Length == 0)
            {
                registrarTextBoxDoctor.Text = "ID Doctor";
                registrarTextBoxDoctor.ForeColor = SystemColors.GrayText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/

        private void Initialize()
        {
            this.dataTimePickerEcCancelDate.Checked = false;
            ////registrarTextBoxIDVisit
            //registrarTextBoxIDVisit.ForeColor = SystemColors.GrayText;
            //registrarTextBoxIDVisit.Text = "ID Visit";
            //this.registrarTextBoxIDVisit.Leave += new System.EventHandler(this.registrarTextBoxIDVisit_Leave);
            //this.registrarTextBoxIDVisit.Enter += new System.EventHandler(this.registrarTextBoxIDVisit_Enter);

            ////registrarTextBoxDescription
            //registrarTextBoxDescription.ForeColor = SystemColors.GrayText;
            //registrarTextBoxDescription.Text = "Description";
            //this.registrarTextBoxDescription.Leave += new System.EventHandler(this.registrarTextBoxDescription_Leave);
            //this.registrarTextBoxDescription.Enter += new System.EventHandler(this.registrarTextBoxDescription_Enter);

            ////registrarTextBoxDiagnosis
            //registrarTextBoxDiagnosis.ForeColor = SystemColors.GrayText;
            //registrarTextBoxDiagnosis.Text = "Diagnosis";
            //this.registrarTextBoxDiagnosis.Leave += new System.EventHandler(this.registrarTextBoxDiagnosis_Leave);
            //this.registrarTextBoxDiagnosis.Enter += new System.EventHandler(this.registrarTextBoxDiagnosis_Enter);

            ////registrarTextBoxState
            //registrarTextBoxState.ForeColor = SystemColors.GrayText;
            //registrarTextBoxState.Text = "State";
            //this.registrarTextBoxState.Leave += new System.EventHandler(this.registrarTextBoxState_Leave);
            //this.registrarTextBoxState.Enter += new System.EventHandler(this.registrarTextBoxState_Enter);

            //registrarTextBoxRegDate
            //registrarTextBoxRegDate.ForeColor = SystemColors.GrayText;
            //registrarTextBoxRegDate.Text = "Registration date";
            //this.registrarTextBoxRegDate.Leave += new System.EventHandler(this.registrarTextBoxRegDate_Leave);
            //this.registrarTextBoxRegDate.Enter += new System.EventHandler(this.registrarTextBoxRegDate_Enter);

            ////registrarTextBoxExCancelDate
            //registrarTextBoxExCancelDate.ForeColor = SystemColors.GrayText;
            //registrarTextBoxExCancelDate.Text = "Execution, cancel date";
            //this.registrarTextBoxExCancelDate.Leave += new System.EventHandler(this.registrarTextBoxExCancelDate_Leave);
            //this.registrarTextBoxExCancelDate.Enter += new System.EventHandler(this.registrarTextBoxExCancelDate_Enter);

            ////registrarTextBoxIDRegistration
            //registrarTextBoxIDRegistration.ForeColor = SystemColors.GrayText;
            //registrarTextBoxIDRegistration.Text = "ID Registration";
            //this.registrarTextBoxIDRegistration.Leave += new System.EventHandler(this.registrarTextBoxIDRegistration_Leave);
            //this.registrarTextBoxIDRegistration.Enter += new System.EventHandler(this.registrarTextBoxIDRegistration_Enter);

            //registrarTextBoxIDPatient
            registrarTextBoxPatient.ForeColor = SystemColors.GrayText;
            registrarTextBoxPatient.Text = "ID Patient";
            this.registrarTextBoxPatient.Leave += new System.EventHandler(this.registrarTextBoxIDPatient_Leave);
            this.registrarTextBoxPatient.Enter += new System.EventHandler(this.registrarTextBoxIDPatient_Enter);

            //registrarTextBoxIDDoctor
            registrarTextBoxDoctor.ForeColor = SystemColors.GrayText;
            registrarTextBoxDoctor.Text = "ID Doctor";
            this.registrarTextBoxDoctor.Leave += new System.EventHandler(this.registrarTextBoxIDDoctor_Leave);
            this.registrarTextBoxDoctor.Enter += new System.EventHandler(this.registrarTextBoxIDDoctor_Enter);






        }

        private void registrarCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarTextBoxPatient_Clicked(object sender, EventArgs e)
        {
            SelectPersonForm registrarSelectPatient = new SelectPersonForm();
            registrarSelectPatient.setRegistrarAddButtonEnableDisable(false);
            registrarSelectPatient.ShowDialog(this);
        }

        private void registrarApproveButton_Click(object sender, EventArgs e)
        {

        }

        private void registrarTextBoxPatient_TextChanged(object sender, EventArgs e)
        {

        }

        public void setRegistrarCancelVisitButtonEnableDisable(bool set)
        {
            this.registrarCancelVisitButton.Enabled = set;
        }

        public void setRegistrarApproveButtonEnableDisable(bool set)
        {
            this.registrarApproveButton.Enabled = set;
        }

        private void registrarTextBoxDoctor_Clicked(object sender, EventArgs e)
        {

            SelectPersonForm registrarSelectDoctor = new SelectPersonForm();
            registrarSelectDoctor.setRegistrarAddButtonEnableDisable(false);
            registrarSelectDoctor.ShowDialog(this);
        }
    }
}

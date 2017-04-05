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
            InitializeTextBoxes();
        }

        //registrarTextBoxIDVisit
        private void registrarTextBoxIDVisit_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxIDVisit.Text.Length == 0)
            {
                registrarTextBoxIDVisit.Text = "ID Visit";
                registrarTextBoxIDVisit.ForeColor = SystemColors.GrayText;
            }
        }

        private void registrarTextBoxIDVisit_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxIDVisit.Text == "ID Visit")
            {
                registrarTextBoxIDVisit.Text = "";
                registrarTextBoxIDVisit.ForeColor = SystemColors.WindowText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxDescription
        private void registrarTextBoxDescription_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxDescription.Text.Length == 0)
            {
                registrarTextBoxDescription.Text = "Description";
                registrarTextBoxDescription.ForeColor = SystemColors.GrayText;
            }
        }


        private void registrarTextBoxDescription_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxDescription.Text == "Description")
            {
                registrarTextBoxDescription.Text = "";
                registrarTextBoxDescription.ForeColor = SystemColors.WindowText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxDiagnosis
        private void registrarTextBoxDiagnosis_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxDiagnosis.Text == "Diagnosis")
            {
                registrarTextBoxDiagnosis.Text = "";
                registrarTextBoxDiagnosis.ForeColor = SystemColors.WindowText;
            }
        }


        private void registrarTextBoxDiagnosis_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxDiagnosis.Text.Length == 0)
            {
                registrarTextBoxDiagnosis.Text = "Diagnosis";
                registrarTextBoxDiagnosis.ForeColor = SystemColors.GrayText;
            }
        }

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxState
        private void registrarTextBoxState_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxState.Text == "State")
            {
                registrarTextBoxState.Text = "";
                registrarTextBoxState.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxState_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxState.Text.Length == 0)
            {
                registrarTextBoxState.Text = "State";
                registrarTextBoxState.ForeColor = SystemColors.GrayText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/


        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxRegDate
        private void registrarTextBoxRegDate_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxRegDate.Text == "Registration date")
            {
                registrarTextBoxRegDate.Text = "";
                registrarTextBoxRegDate.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxRegDate_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxRegDate.Text.Length == 0)
            {
                registrarTextBoxRegDate.Text = "Registration date";
                registrarTextBoxRegDate.ForeColor = SystemColors.GrayText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxExCancelDate

        private void registrarTextBoxExCancelDate_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxExCancelDate.Text == "Execution, cancel date")
            {
                registrarTextBoxExCancelDate.Text = "";
                registrarTextBoxExCancelDate.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxExCancelDate_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxExCancelDate.Text.Length == 0)
            {
                registrarTextBoxExCancelDate.Text = "Execution, cancel date";
                registrarTextBoxExCancelDate.ForeColor = SystemColors.GrayText;
            }
        }

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDPatient

        private void registrarTextBoxIDPatient_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxIDPatient.Text == "ID Patient")
            {
                registrarTextBoxIDPatient.Text = "";
                registrarTextBoxIDPatient.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxIDPatient_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxIDPatient.Text.Length == 0)
            {
                registrarTextBoxIDPatient.Text = "ID Patient";
                registrarTextBoxIDPatient.ForeColor = SystemColors.GrayText;
            }
        }

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDRegistration

        private void registrarTextBoxIDRegistration_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxIDRegistration.Text == "ID Registration")
            {
                registrarTextBoxIDRegistration.Text = "";
                registrarTextBoxIDRegistration.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxIDRegistration_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxIDRegistration.Text.Length == 0)
            {
                registrarTextBoxIDRegistration.Text = "ID Registration";
                registrarTextBoxIDRegistration.ForeColor = SystemColors.GrayText;
            }
        }

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDDoctor

        private void registrarTextBoxIDDoctor_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxIDDoctor.Text == "ID Doctor")
            {
                registrarTextBoxIDDoctor.Text = "";
                registrarTextBoxIDDoctor.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxIDDoctor_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxIDDoctor.Text.Length == 0)
            {
                registrarTextBoxIDDoctor.Text = "ID Doctor";
                registrarTextBoxIDDoctor.ForeColor = SystemColors.GrayText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/

        private void InitializeTextBoxes()
        {
            //registrarTextBoxIDVisit
            registrarTextBoxIDVisit.ForeColor = SystemColors.GrayText;
            registrarTextBoxIDVisit.Text = "ID Visit";
            this.registrarTextBoxIDVisit.Leave += new System.EventHandler(this.registrarTextBoxIDVisit_Leave);
            this.registrarTextBoxIDVisit.Enter += new System.EventHandler(this.registrarTextBoxIDVisit_Enter);

            //registrarTextBoxDescription
            registrarTextBoxDescription.ForeColor = SystemColors.GrayText;
            registrarTextBoxDescription.Text = "Description";
            this.registrarTextBoxDescription.Leave += new System.EventHandler(this.registrarTextBoxDescription_Leave);
            this.registrarTextBoxDescription.Enter += new System.EventHandler(this.registrarTextBoxDescription_Enter);

            //registrarTextBoxDiagnosis
            registrarTextBoxDiagnosis.ForeColor = SystemColors.GrayText;
            registrarTextBoxDiagnosis.Text = "Diagnosis";
            this.registrarTextBoxDiagnosis.Leave += new System.EventHandler(this.registrarTextBoxDiagnosis_Leave);
            this.registrarTextBoxDiagnosis.Enter += new System.EventHandler(this.registrarTextBoxDiagnosis_Enter);

            //registrarTextBoxState
            registrarTextBoxState.ForeColor = SystemColors.GrayText;
            registrarTextBoxState.Text = "State";
            this.registrarTextBoxState.Leave += new System.EventHandler(this.registrarTextBoxState_Leave);
            this.registrarTextBoxState.Enter += new System.EventHandler(this.registrarTextBoxState_Enter);

            //registrarTextBoxRegDate
            registrarTextBoxRegDate.ForeColor = SystemColors.GrayText;
            registrarTextBoxRegDate.Text = "Registration date";
            this.registrarTextBoxRegDate.Leave += new System.EventHandler(this.registrarTextBoxRegDate_Leave);
            this.registrarTextBoxRegDate.Enter += new System.EventHandler(this.registrarTextBoxRegDate_Enter);

            //registrarTextBoxExCancelDate
            registrarTextBoxExCancelDate.ForeColor = SystemColors.GrayText;
            registrarTextBoxExCancelDate.Text = "Execution, cancel date";
            this.registrarTextBoxExCancelDate.Leave += new System.EventHandler(this.registrarTextBoxExCancelDate_Leave);
            this.registrarTextBoxExCancelDate.Enter += new System.EventHandler(this.registrarTextBoxExCancelDate_Enter);

            //registrarTextBoxIDRegistration
            registrarTextBoxIDRegistration.ForeColor = SystemColors.GrayText;
            registrarTextBoxIDRegistration.Text = "ID Registration";
            this.registrarTextBoxIDRegistration.Leave += new System.EventHandler(this.registrarTextBoxIDRegistration_Leave);
            this.registrarTextBoxIDRegistration.Enter += new System.EventHandler(this.registrarTextBoxIDRegistration_Enter);

            //registrarTextBoxIDPatient
            registrarTextBoxIDPatient.ForeColor = SystemColors.GrayText;
            registrarTextBoxIDPatient.Text = "ID Patient";
            this.registrarTextBoxIDPatient.Leave += new System.EventHandler(this.registrarTextBoxIDPatient_Leave);
            this.registrarTextBoxIDPatient.Enter += new System.EventHandler(this.registrarTextBoxIDPatient_Enter);

            //registrarTextBoxIDDoctor
            registrarTextBoxIDDoctor.ForeColor = SystemColors.GrayText;
            registrarTextBoxIDDoctor.Text = "ID Doctor";
            this.registrarTextBoxIDDoctor.Leave += new System.EventHandler(this.registrarTextBoxIDDoctor_Leave);
            this.registrarTextBoxIDDoctor.Enter += new System.EventHandler(this.registrarTextBoxIDDoctor_Enter);






        }

        private void registrarCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

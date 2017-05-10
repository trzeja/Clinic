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
    public partial class RegistrarAddPatientForm : Form
    {
        public RegistrarAddPatientForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void registrarAddPatientButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void peselBox_Enter(object sender, EventArgs e)
        {
            if (peselBox.Text == "PESEL")
            {
                peselBox.Text = "";
                peselBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void peselBox_Leave(object sender, EventArgs e)
        {
            if (peselBox.Text.Length == 0)
            {
                peselBox.Text = "PESEL";
                peselBox.ForeColor = SystemColors.GrayText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/

        private void fnameBox_Enter(object sender, EventArgs e)
        {
            if (fnameBox.Text == "First Name")
            {
                fnameBox.Text = "";
                fnameBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void fnameBox_Leave(object sender, EventArgs e)
        {
            if (fnameBox.Text.Length == 0)
            {
                fnameBox.Text = "First Name";
                fnameBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void lnameBox_Enter(object sender, EventArgs e)
        {
            if (lnameBox.Text == "Last Name")
            {
                lnameBox.Text = "";
                lnameBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void lnameBox_Leave(object sender, EventArgs e)
        {
            if (lnameBox.Text.Length == 0)
            {
                lnameBox.Text = "Last Name";
                lnameBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void InitializeTextBoxes()
        {
           
           
            //peselBox
            peselBox.ForeColor = SystemColors.GrayText;
            peselBox.Text = "PESEL";
            this.peselBox.Leave += new System.EventHandler(this.peselBox_Leave);
            this.peselBox.Enter += new System.EventHandler(this.peselBox_Enter);

            //fnameBox
            fnameBox.ForeColor = SystemColors.GrayText;
            fnameBox.Text = "First Name";
            this.fnameBox.Leave += new System.EventHandler(this.fnameBox_Leave);
            this.fnameBox.Enter += new System.EventHandler(this.fnameBox_Enter);

            //lnameBox
            lnameBox.ForeColor = SystemColors.GrayText;
            lnameBox.Text = "Last Name";
            this.lnameBox.Leave += new System.EventHandler(this.lnameBox_Leave);
            this.lnameBox.Enter += new System.EventHandler(this.lnameBox_Enter);




        }
    }
}

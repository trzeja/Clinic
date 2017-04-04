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
    public partial class AdminSearchForm : Form
    {
        public AdminSearchForm()
        {
            InitializeComponent();
            InitializeTextBoxes();


        }
        //adminTextBoxUserName
        private void adminTextBoxUserName_Leave(object sender, EventArgs e)
        {
            if (adminTextBoxUserName.Text.Length == 0)
            {
                adminTextBoxUserName.Text = "User Name";
                adminTextBoxUserName.ForeColor = SystemColors.GrayText;
            }
        }

        private void adminTextBoxUserName_Enter(object sender, EventArgs e)
        {
            if (adminTextBoxUserName.Text == "User Name")
            {
                adminTextBoxUserName.Text = "";
                adminTextBoxUserName.ForeColor = SystemColors.WindowText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/
        //adminTextBoxPassword
        private void adminTextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (adminTextBoxPassword.Text.Length == 0)
            {
                adminTextBoxPassword.Text = "Password";
                adminTextBoxPassword.ForeColor = SystemColors.GrayText;
            }
        }


        private void adminTextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (adminTextBoxPassword.Text == "Password")
            {
                adminTextBoxPassword.Text = "";
                adminTextBoxPassword.ForeColor = SystemColors.WindowText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/
        //adminTextBoxRetireDate
        private void adminTextBoxRetireDate_Enter(object sender, EventArgs e)
        {
            if (adminTextBoxRetireDate.Text == "Retire Date")
            {
                adminTextBoxRetireDate.Text = "";
                adminTextBoxRetireDate.ForeColor = SystemColors.WindowText;
            }
        }


        private void adminTextBoxRetireDate_Leave(object sender, EventArgs e)
        {
            if (adminTextBoxRetireDate.Text.Length == 0)
            {
                adminTextBoxRetireDate.Text = "Retire Date";
                adminTextBoxRetireDate.ForeColor = SystemColors.GrayText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/
        //adminTextBoxRoles
        private void adminTextBoxRoles_Enter(object sender, EventArgs e)
        {
            if (adminTextBoxRoles.Text == "Role")
            {
                adminTextBoxRoles.Text = "";
                adminTextBoxRoles.ForeColor = SystemColors.WindowText;
            }
        }

        private void adminTextBoxRoles_Leave(object sender, EventArgs e)
        {
            if (adminTextBoxRoles.Text.Length == 0)
            {
                adminTextBoxRoles.Text = "Role";
                adminTextBoxRoles.ForeColor = SystemColors.GrayText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/
        //adminTextBoxLname
        private void adminTextBoxLname_Enter(object sender, EventArgs e)
        {
            if (adminTextBoxLname.Text == "Last Name")
            {
                adminTextBoxLname.Text = "";
                adminTextBoxLname.ForeColor = SystemColors.WindowText;
            }
        }

        private void adminTextBoxLname_Leave(object sender, EventArgs e)
        {
            if (adminTextBoxLname.Text.Length == 0)
            {
                adminTextBoxLname.Text = "Last Name";
                adminTextBoxLname.ForeColor = SystemColors.GrayText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/

        private void adminTextBoxFname_Enter(object sender, EventArgs e)
        {
            if (adminTextBoxFname.Text == "First Name")
            {
                adminTextBoxFname.Text = "";
                adminTextBoxFname.ForeColor = SystemColors.WindowText;
            }
        }

        private void adminTextBoxFname_Leave(object sender, EventArgs e)
        {
            if (adminTextBoxFname.Text.Length == 0)
            {
                adminTextBoxFname.Text = "First Name";
                adminTextBoxFname.ForeColor = SystemColors.GrayText;
            }
        }

      private void InitializeTextBoxes()
        {
            //adminTextBoxUserName
            adminTextBoxUserName.ForeColor = SystemColors.GrayText;
            adminTextBoxUserName.Text = "User Name";
            this.adminTextBoxUserName.Leave += new System.EventHandler(this.adminTextBoxUserName_Leave);
            this.adminTextBoxUserName.Enter += new System.EventHandler(this.adminTextBoxUserName_Enter);

            //adminTextBoxPassword
            adminTextBoxPassword.ForeColor = SystemColors.GrayText;
            adminTextBoxPassword.Text = "Password";
            this.adminTextBoxPassword.Leave += new System.EventHandler(this.adminTextBoxPassword_Leave);
            this.adminTextBoxPassword.Enter += new System.EventHandler(this.adminTextBoxPassword_Enter);

            //adminTextBoxRetireDate
            adminTextBoxRetireDate.ForeColor = SystemColors.GrayText;
            adminTextBoxRetireDate.Text = "Retire Date";
            this.adminTextBoxRetireDate.Leave += new System.EventHandler(this.adminTextBoxRetireDate_Leave);
            this.adminTextBoxRetireDate.Enter += new System.EventHandler(this.adminTextBoxRetireDate_Enter);

            //adminTextBoxRoles
            adminTextBoxRoles.ForeColor = SystemColors.GrayText;
            adminTextBoxRoles.Text = "Role";
            this.adminTextBoxRoles.Leave += new System.EventHandler(this.adminTextBoxRoles_Leave);
            this.adminTextBoxRoles.Enter += new System.EventHandler(this.adminTextBoxRoles_Enter);

            //adminTextBoxLname
            adminTextBoxLname.ForeColor = SystemColors.GrayText;
            adminTextBoxLname.Text = "Last Name";
            this.adminTextBoxLname.Leave += new System.EventHandler(this.adminTextBoxLname_Leave);
            this.adminTextBoxLname.Enter += new System.EventHandler(this.adminTextBoxLname_Enter);

            //adminTextBoxFname
            adminTextBoxFname.ForeColor = SystemColors.GrayText;
            adminTextBoxFname.Text = "First Name";
            this.adminTextBoxFname.Leave += new System.EventHandler(this.adminTextBoxFname_Leave);
            this.adminTextBoxFname.Enter += new System.EventHandler(this.adminTextBoxFname_Enter);

          


        }

        private void adminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


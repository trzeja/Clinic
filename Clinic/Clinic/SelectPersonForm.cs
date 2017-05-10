﻿using System;
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
    public partial class SelectPersonForm : Form
    {
        public SelectPersonForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void registrarAddPatientButton_Click(object sender, EventArgs e)
        {
            RegistrarAddPatientForm registrarAddPatientForm = new RegistrarAddPatientForm();
            registrarAddPatientForm.ShowDialog(this);
        }

        public void setRegistrarAddButtonEnableDisable(bool set)
        {
            this.registrarAddButton.Enabled = set;
        }


        //fnameTextbox
        private void fnameTextbox_Leave(object sender, EventArgs e)
        {
            if (fnameTextbox.Text.Length == 0)
            {
                fnameTextbox.Text = "First Name";
                fnameTextbox.ForeColor = SystemColors.GrayText;
            }
        }

        private void fnameTextbox_Enter(object sender, EventArgs e)
        {
            if (fnameTextbox.Text == "First Name")
            {
                fnameTextbox.Text = "";
                fnameTextbox.ForeColor = SystemColors.WindowText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/
        //lnameTextbox
        private void lnameTextbox_Leave(object sender, EventArgs e)
        {
            if (lnameTextbox.Text.Length == 0)
            {
                lnameTextbox.Text = "Last Name";
                lnameTextbox.ForeColor = SystemColors.GrayText;
            }
        }


        private void lnameTextbox_Enter(object sender, EventArgs e)
        {
            if (lnameTextbox.Text == "Last Name")
            {
                lnameTextbox.Text = "";
                lnameTextbox.ForeColor = SystemColors.WindowText;
            }
        }
        private void InitializeTextBoxes()
        {
            //fnameTextbox
            fnameTextbox.ForeColor = SystemColors.GrayText;
            fnameTextbox.Text = "First Name";
            this.fnameTextbox.Leave += new System.EventHandler(this.fnameTextbox_Leave);
            this.fnameTextbox.Enter += new System.EventHandler(this.fnameTextbox_Enter);

            //lnameTextbox
            lnameTextbox.ForeColor = SystemColors.GrayText;
            lnameTextbox.Text = "Last Name";
            this.lnameTextbox.Leave += new System.EventHandler(this.lnameTextbox_Leave);
            this.lnameTextbox.Enter += new System.EventHandler(this.lnameTextbox_Enter);

        }
        }
}
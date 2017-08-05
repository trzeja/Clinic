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
  
    public partial class RegistrarAddFrom : Form
    {
        private bool modifyTrueAddFalse;
        private Point point;
        public RegistrarAddFrom()
        {
            //425; 290
            //318; 210
            //this.Size = new Size(425, 290);
            //if (modifyTrueAddFalse == false)
            //{
            //    this.Size = new Size(425, 290);
               
              
            //}
            //else
            //{
            //    this.Size = new Size(425, 550);
            //    point = new Point(322, 210);
            //   // this.registrarApproveButton.Location = point;

            //}
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

            this.registrarTextBoxPatient.ReadOnly = true;
            this.registrarTextBoxDoctor.ReadOnly = true;




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
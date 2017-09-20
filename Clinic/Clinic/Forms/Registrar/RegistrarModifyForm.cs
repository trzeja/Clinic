﻿using BizzLayer;
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
        private int idVisit;
        private int idDoctor;
        private int idPatient;
        public RegistrarAddModifyForm(int? idVisit = null)
        {
            InitializeComponent();
            Initialize(idVisit);
            this.idDoctor = -1;
            
        }

        public RegistrarAddModifyForm(int idPatient,int? idReg)
        {
            InitializeComponent();
            this.idPatient = idPatient;
            SetPatientName(idPatient);

        }

        private void SetPatientName(int idPatient)
        {

            Patient patient = new Patient();
            patient.id_patient = idPatient;
            patient= RegistrationFacade.GetPatientByID(patient);
            registrarTextBoxPatientName.Text = patient.lname;
            this.idDoctor = -1;
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
                this.idVisit = visit.id_visit;
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
            //this.registrarSelectPatientButton.Visible = !set;
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
            DataLayer.Doctor d = new DataLayer.Doctor();
            SelectPersonForm registrarSelectDoctor = new SelectPersonForm(d);
            registrarSelectDoctor.setRegistrarAddButtonEnableDisable(false);
            registrarSelectDoctor.ShowDialog(this);
            this.idDoctor = -1;
            this.idDoctor = registrarSelectDoctor.getID();
            registrarTextBoxDoctor.Text = registrarSelectDoctor.getLname();
            

        }
        public void updateVisit(int id)
        {
            // this.idVisit;
            if (!(this.idDoctor < 0))
            {


                Visit visitToset = new Visit() ;
                visitToset.id_doctor = this.idDoctor;
                visitToset.id_visit = id;
                visitToset.registration_date = this.dataTimePickerRegDate.Value;
                visitToset.state = this.registrarStateComboBox.SelectedItem.ToString();
                if (visitToset.state == "REG")
                {
                    
                    visitToset.execution_cancel_datetime = null;
                }
                else
                {
                    visitToset.execution_cancel_datetime = DateTime.Today;
                }
                RegistrationFacade.updateVisit(visitToset);
            }
        }

    }
}

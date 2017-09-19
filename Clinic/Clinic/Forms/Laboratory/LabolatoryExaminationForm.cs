using BizzLayer.Facades;
using DataLayer;
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
    public partial class LabolatoryExaminationForm : Form
    {
        private int id_exam = 0;
        private int id_user = 0;
        public LabolatoryExaminationForm(int idExam=0)
        {
            InitializeComponent();
            SetReadOnlyMode();
            id_exam = idExam;
            Initialize();
        }

        private void LabExaminationLabWorkerSubmitButton_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            Laboratory_examination labEx = new Laboratory_examination();
            labEx.id_laboratory_examination = id_exam;
            labEx.examination_execution_date = time;
            labEx.state = "DONE";
            labEx.result = LabExaminationExamResultTextBox.Text;
            labEx.id_laboratory_woker = id_user;
            LaboratoryFacade.UpdateExamination(labEx);
            this.Close();
            //trzeba odswiezyc grid nizej
        }

        private void LabExaminationLabWorkerCancelButton_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
        }

        private void Initialize()
        {
            if (id_exam != 0)
            {
                Laboratory_examination labExam = CommonFacade.GetLabExam(id_exam);
                Patient patient = CommonFacade.GetPatientByVisit(labExam.id_visit);
                LabExaminationPatientFirstNameTextBox.Text = patient.fname;
                LabExaminationPatientLastNameTextBox.Text = patient.lname;
                LabExaminationPatientPeselTextBox.Text = patient.PESEL;
                LabExaminationExamTypeComboBox.Items.Add(CommonFacade.GetExamCodeName(labExam.code));
                LabExaminationExamTypeComboBox.SelectedIndex = 0;
                string state;
                switch (labExam.state) {
                    case ("ORD"):
                        state = "Ordered";
                        break;
                    case ("DONE"):
                        state = "Waiting for approval";
                        break;
                    case ("APP"):
                        state = "Approved";
                        break;
                    case ("CANC_LABW"):
                        state = "Canceled by laboratory worker";
                        break;
                    case ("CANC_LABM"):
                        state = "Canceled by laboratory manager";
                        break;
                    default:
                        state = "";
                        break;
                }
                LabExaminationExamStateComboBox.Items.Add(state);
                LabExaminationExamStateComboBox.SelectedIndex = 0;
                DataLayer.Doctor doctor = CommonFacade.GetDoctorByVisit(labExam.id_visit);
                LabExaminationDoctorFirstNameTextBox.Text = doctor.User.fname;
                LabExaminationDoctorLastNameTextBox.Text = doctor.User.lname;
                LabExaminationExamOrderDateTimePicker.Value = labExam.order_date;
                LabExaminationDoctorCommentsTextBox.Text = labExam.doctor_comments;
                if (labExam.id_laboratory_woker != null)
                {
                    Laboratory_worker labw = CommonFacade.GetLabW(labExam.id_laboratory_woker.Value);
                    LabExaminationLabWorkerFirstNameTextBox.Text = labw.User.fname;
                    LabExaminationLabWorkerLastNameTextBox.Text = labw.User.lname;
                }
                if (labExam.examination_execution_date == null)
                {
                    LabExaminationExamExaminationDateTimePicker.CustomFormat = " ";
                    LabExaminationExamExaminationDateTimePicker.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    LabExaminationExamExaminationDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                    LabExaminationExamExaminationDateTimePicker.Value = labExam.examination_execution_date.Value;
                }
                LabExaminationExamResultTextBox.Text = labExam.result;

                if (labExam.id_laboratory_manager != null)
                {
                    Laboratory_manager labm = CommonFacade.GetLabM(labExam.id_laboratory_manager.Value);
                    LabExaminationLabManagerFirstNameTextBox.Text = labm.User.fname;
                    LabExaminationLabManagerLastNameTextBox.Text = labm.User.lname;
                }
                if (labExam.examination_approval_date == null)
                {
                    LabExaminationExamApprovalDateTimePicker.CustomFormat = " ";
                    LabExaminationExamApprovalDateTimePicker.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    LabExaminationExamApprovalDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                    LabExaminationExamApprovalDateTimePicker.Value = labExam.examination_approval_date.Value;
                }
                LabExaminationLabManagerCommentsTextBox.Text = labExam.lab_manager_comments;
            }
        }
        // public void SetWindowMode
        public void SetLabWorkerMode(int id_person)
        {
            id_user = id_person;
            SetWindowMode(0);
        }

        public void SetLabManagerMode(int id_person)
        {
            id_user = id_person;
            SetWindowMode(1);
        }

        public void SetReadOnlyMode()
        {
            SetWindowMode(-1);
        }
        private void SetWindowMode(int mode)//0 - lab worker, 1 - lab manager
        {
            switch (mode)
            {
                case 0:
                    {//lab worker
                        //patient
                        //LabExaminationPatientFirstNameTextBox.ReadOnly = true;
                        //LabExaminationPatientLastNameTextBox.ReadOnly = true;
                        //LabExaminationPatientPeselTextBox.ReadOnly = true;
                        ////doctor
                        //LabExaminationDoctorFirstNameTextBox.ReadOnly = true;
                        //LabExaminationDoctorLastNameTextBox.ReadOnly = true;
                        //LabExaminationDoctorCommentsTextBox.ReadOnly = true;
                        //lab worker
                        //LabExaminationLabWorkerFirstNameTextBox.ReadOnly = true;
                        //LabExaminationLabWorkerLastNameTextBox.ReadOnly = true;
                        LabExaminationExamResultTextBox.ReadOnly = false;
                        LabExaminationExamResultTextBox.Enabled = true;
                        LabExaminationLabWorkerSubmitButton.Enabled = true;
                        LabExaminationLabWorkerCancelButton.Enabled = true;
                        //lab manager
                        //LabExaminationLabManagerFirstNameTextBox.ReadOnly = true;
                        //LabExaminationLabManagerLastNameTextBox.ReadOnly = true;
                        LabExaminationLabManagerCommentsTextBox.ReadOnly = true;
                        LabExaminationLabManagerApproveButton.Enabled = false;
                        LabExaminationLabManagerCancelButton.Enabled = false;
                        //other
                        //LabExaminationExamStateComboBox.Enabled = false;
                        //LabExaminationExamTypeComboBox.Enabled = false;
                        //LabExaminationExamOrderDateTimePicker.Enabled = false;
                        Laboratory_worker labW = CommonFacade.GetLabW(id_user);
                        LabExaminationLabWorkerFirstNameTextBox.Text = labW.User.fname;
                        LabExaminationLabWorkerLastNameTextBox.Text = labW.User.lname;
                        //LabExaminationExamExaminationDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                        LabExaminationExamExaminationDateTimePicker.Format = DateTimePickerFormat.Long;
                        LabExaminationExamExaminationDateTimePicker.Value = DateTime.Now;
                    }
                    break;
                case 1:
                    {//lab manager
                        //patient
                        //LabExaminationPatientFirstNameTextBox.ReadOnly = true;
                        //LabExaminationPatientLastNameTextBox.ReadOnly = true;
                        //LabExaminationPatientPeselTextBox.ReadOnly = true;
                        ////doctor
                        //LabExaminationDoctorFirstNameTextBox.ReadOnly = true;
                        //LabExaminationDoctorLastNameTextBox.ReadOnly = true;
                        //LabExaminationDoctorCommentsTextBox.ReadOnly = true;
                        //lab worker
                        //LabExaminationLabWorkerFirstNameTextBox.ReadOnly = true;
                        //LabExaminationLabWorkerLastNameTextBox.ReadOnly = true;
                        LabExaminationExamResultTextBox.ReadOnly = true;
                        LabExaminationLabWorkerSubmitButton.Enabled = false;
                        LabExaminationLabWorkerCancelButton.Enabled = false;
                        //lab manager
                        //LabExaminationLabManagerFirstNameTextBox.ReadOnly = true;
                        //LabExaminationLabManagerLastNameTextBox.ReadOnly = true;
                        LabExaminationLabManagerCommentsTextBox.ReadOnly = false;
                        LabExaminationLabManagerApproveButton.Enabled = true;
                        LabExaminationLabManagerCancelButton.Enabled = true;
                        //other
                        //LabExaminationExamStateComboBox.Enabled = false;
                        //LabExaminationExamTypeComboBox.Enabled = false;
                        //LabExaminationExamOrderDateTimePicker.Enabled = false;
                    }
                    break;
                default:
                    {//read only
                        ////patient
                        //LabExaminationPatientFirstNameTextBox.ReadOnly = true;
                        //LabExaminationPatientLastNameTextBox.ReadOnly = true;
                        //LabExaminationPatientPeselTextBox.ReadOnly = true;
                        LabExaminationPatientFirstNameTextBox.Enabled = false;
                        LabExaminationPatientLastNameTextBox.Enabled = false;
                        LabExaminationPatientPeselTextBox.Enabled = false;
                        ////doctor
                        //LabExaminationDoctorFirstNameTextBox.ReadOnly = true;
                        //LabExaminationDoctorLastNameTextBox.ReadOnly = true;
                        //LabExaminationDoctorCommentsTextBox.ReadOnly = true;
                        LabExaminationDoctorFirstNameTextBox.Enabled = false;
                        LabExaminationDoctorLastNameTextBox.Enabled = false;
                        LabExaminationDoctorCommentsTextBox.Enabled = false;
                        ////lab worker
                        //LabExaminationLabWorkerFirstNameTextBox.ReadOnly = true;
                        //LabExaminationLabWorkerLastNameTextBox.ReadOnly = true;
                        LabExaminationLabWorkerFirstNameTextBox.Enabled = false;
                        LabExaminationLabWorkerLastNameTextBox.Enabled = false;
                        LabExaminationExamResultTextBox.Enabled = false;
                        LabExaminationExamResultTextBox.ReadOnly = true;
                        LabExaminationLabWorkerSubmitButton.Enabled = false;
                        LabExaminationLabWorkerCancelButton.Enabled = false;
                        //lab manager
                        //LabExaminationLabManagerFirstNameTextBox.ReadOnly = true;
                        //LabExaminationLabManagerLastNameTextBox.ReadOnly = true;
                        LabExaminationLabManagerFirstNameTextBox.Enabled = false;
                        LabExaminationLabManagerLastNameTextBox.Enabled = false;
                        LabExaminationLabManagerCommentsTextBox.Enabled = false;
                        LabExaminationLabManagerCommentsTextBox.ReadOnly = true;
                        LabExaminationLabManagerApproveButton.Enabled = false;
                        LabExaminationLabManagerCancelButton.Enabled = false;
                        //other
                        //LabExaminationExamStateComboBox.Enabled = false;
                        //LabExaminationExamTypeComboBox.Enabled = false;
                        //LabExaminationExamOrderDateTimePicker.Enabled = false;

                    }
                    break;
            }
        }
    }
}

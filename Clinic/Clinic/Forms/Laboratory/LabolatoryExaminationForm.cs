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
        public LabolatoryExaminationForm(int idExam=0)
        {
            InitializeComponent();
            SetReadOnlyMode();
            id_exam = idExam;
            Initialize();
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
    }
}

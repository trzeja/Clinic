using BizzLayer;
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

namespace Clinic
{
    public partial class VisitInfoViewForm : Form
    {
        public VisitInfoViewForm(int idVisit)
        {
            InitializeComponent();
            Visit visit = DoctorFacade.GetVisitById(idVisit);
            Patient patient = DoctorFacade.GetPatientByVisit(idVisit);
            BizzLayer.Doctor doctor = DoctorFacade.GetDoctorByVisit(idVisit);
            VisitViewPatientFirstNameTextBox.Text = patient.fname;
            VisitViewPatientLastNameTextBox.Text = patient.lname;
            VisitViewPatientPeselTextBox.Text = patient.PESEL;
            VisitViewDocorFirstNameTextBox.Text = doctor.User.fname;
            VisitViewDoctorLastNameTextBox.Text = doctor.User.lname;
            VisitViewVisitStateComboBox.Text = visit.state;
            VisitViewRegisterDateTimePicker.Value = visit.registration_date;
            //tu wywala jak nie ma
            if (visit.execution_cancel_datetime == null)
            {
                VisitViewExecCancelDateTimePicker.CustomFormat = " ";
                VisitViewExecCancelDateTimePicker.Format = DateTimePickerFormat.Custom;
            } else
            {
                VisitViewExecCancelDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                VisitViewExecCancelDateTimePicker.Value = visit.execution_cancel_datetime.Value;
            }
            VisitViewDescriptionTextBox.Text = visit.description;
            VisitViewDiagnosisTextBox.Text = visit.diagnosis;

            //to do :
            //w zaleznosci od stanu zmien VisitViewExecCancelDateLabel.Text w na "Execution date" lub na "Cancel date" albo (...)Label.Visible=false
        }
    }
}

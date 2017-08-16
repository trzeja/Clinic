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
    public partial class DoctorVisitViewForm : Form
    {
        public DoctorVisitViewForm(int id=0)
        {
            InitializeComponent();
            //initialize data
            doctorVisitPatientDescriptionTextBox.Text = "Description";
            doctorVisitPatientDescriptionTextBox.ForeColor = SystemColors.GrayText;
            doctorVisitPatientDiagnosisTextBox.Text = "Diagnosis";
            doctorVisitPatientDiagnosisTextBox.ForeColor = SystemColors.GrayText;
            this.id = id;
        }

        private void doctorFinishVisitButton_Click(object sender, EventArgs e)
        {
            //validate data
        }

        private void doctorPhysicalExaminationButton_Click(object sender, EventArgs e)
        {
            // refresh examination history
            //MessageBox.Show("Physical examination submited !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DoctorExaminationViewForm examinationView = new DoctorExaminationViewForm();
            examinationView.SetPhyExamMode();
            examinationView.ShowDialog(this);
        }

        private void doctorOrderLaboratoryExaminationButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Laboratory examination ordered !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoctorExaminationViewForm examinationView = new DoctorExaminationViewForm(id);
            examinationView.SetLabExamMode();
            examinationView.ShowDialog(this);
        }

        private void doctorVisitPatientDescriptionTextBox_Enter(object sender, EventArgs e)
        {
            if (doctorVisitPatientDescriptionTextBox.Text == "Description")
            {
                doctorVisitPatientDescriptionTextBox.Text = "";
                doctorVisitPatientDescriptionTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void doctorVisitPatientDescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (doctorVisitPatientDescriptionTextBox.Text == "")
            {
                doctorVisitPatientDescriptionTextBox.Text = "Description";
                doctorVisitPatientDescriptionTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void doctorCancelVisitButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ?", "Cancel the visit...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //cancel visit
            };
        }

        private void doctorVisitPatientDiagnosisTextBox_Leave(object sender, EventArgs e)
        {
            if (doctorVisitPatientDiagnosisTextBox.Text == "")
            {
                doctorVisitPatientDiagnosisTextBox.Text = "Diagnosis";
                doctorVisitPatientDiagnosisTextBox.ForeColor = SystemColors.GrayText;
            }

        }

        private void doctorVisitPatientDiagnosisTextBox_Enter(object sender, EventArgs e)
        {
            if (doctorVisitPatientDiagnosisTextBox.Text == "Diagnosis")
            {
                doctorVisitPatientDiagnosisTextBox.Text = "";
                doctorVisitPatientDiagnosisTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void doctorVisitViewExamHistDetailsButton_Click(object sender, EventArgs e)
        {
            //to do :
            //zobacz jakiego typu jest badanie w zaznaczonej lini i wtedy albo LabExamination albo DoctorExaminationView oba w read only mode ofc
            LabolatoryExaminationForm labExamView = new LabolatoryExaminationForm();
            labExamView.SetReadOnlyMode();
            labExamView.ShowDialog(this);
        }

        private void doctorVisitViewVisitHistDetailsButton_Click(object sender, EventArgs e)
        {
            VisitInfoViewForm visit = new VisitInfoViewForm();
            visit.ShowDialog(this);
        }
        private int id = 0;
    }
}

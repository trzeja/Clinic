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
    public partial class DoctorExaminationViewForm : Form
    {
        public DoctorExaminationViewForm()
        {
            InitializeComponent();
            SetWindowMode(-1);
        }

        private void SetWindowMode(int mode)//0=LAB, 1=PHY, else=PHY_read_only
        {
            switch (mode)
            {
                case 0:
                    {//lab exam
                        doctorExaminationViewExamTypeHeadingLabel.Text = "Laboratory Examination";
                        doctorExaminationViewCommentsResultLabel.Text = "Comments :";
                        doctorExaminationViewSubmitButton.Visible = false;
                        doctorExaminationViewOrderButton.Visible = true;
                        doctorExaminationViewExamTypeComboBox.Enabled = true;
                        doctorExaminationViewCommentsResultTextBox.ReadOnly = false;
                    }
                    break;
                case 1:
                    {//phy exam
                        doctorExaminationViewExamTypeHeadingLabel.Text = "Physical Examination";
                        doctorExaminationViewCommentsResultLabel.Text = "Results :";
                        doctorExaminationViewSubmitButton.Visible = true;
                        doctorExaminationViewOrderButton.Visible = false;
                        doctorExaminationViewExamTypeComboBox.Enabled = true;
                        doctorExaminationViewCommentsResultTextBox.ReadOnly = false;
                    }
                    break;
                default:
                    {//phy exam READ ONLY
                        doctorExaminationViewExamTypeHeadingLabel.Text = "Physical Examination";
                        doctorExaminationViewCommentsResultLabel.Text = "Results :";
                        doctorExaminationViewSubmitButton.Visible = false;
                        doctorExaminationViewOrderButton.Visible = false;
                        doctorExaminationViewExamTypeComboBox.Enabled = false;
                        doctorExaminationViewCommentsResultTextBox.ReadOnly = true;
                    }
                    break;
            }

        }

        public void SetLabExamMode()//labolatory examination mode
        {
            SetWindowMode(0);
        }
        public void SetPhyExamMode()//physical examination mode
        {
            SetWindowMode(1);
        }
        public void SetReadOnlyMode()//physical read only
        {
            SetWindowMode(-1);
        }
    }


}

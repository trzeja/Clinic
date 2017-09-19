using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;
using BizzLayer.Facades;

namespace Clinic
{
    public partial class DoctorExaminationViewForm : Form
    {
        private int id_visit = 0;
        private int id_exam = 0;
        public DoctorExaminationViewForm(int id = 0, int idExam=0)
        {
            InitializeComponent();
            this.id_exam = idExam;
            this.id_visit = id;
            SetWindowMode(-1);
            
            
        }

        private void SetWindowMode(int mode)//0=LAB, 1=PHY
        {
            switch (mode)
            {
                case 0:
                    {//lab exam
                     // doctorExaminationViewExamTypeComboBox
                        doctorExaminationViewExamTypeHeadingLabel.Text = "Laboratory Examination";
                        doctorExaminationViewCommentsResultLabel.Text = "Comments :";
                        doctorExaminationViewSubmitButton.Visible = false;
                        doctorExaminationViewOrderButton.Visible = true;
                        doctorExaminationViewExamTypeComboBox.Enabled = true;
                        doctorExaminationViewCommentsResultTextBox.ReadOnly = false;
                        doctorExaminationViewCommentsResultTextBox.Enabled = true;
                        //dateToComboBox = new List<string>();
                        //var query= DoctorFacade.GetLaboratoryExaminationType();
                        //foreach (var x in query) dateToComboBox.Add( x.ToString());
                        //doctorExaminationViewExamTypeComboBox.DataSource = dateToComboBox;
                        doctorExaminationViewExamTypeComboBox.DataSource = DoctorFacade.GetLaboratoryExaminationType();
                        doctorExaminationViewExamTypeComboBox.SelectedIndex = -1;
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

                        doctorExaminationViewExamTypeComboBox.DataSource = DoctorFacade.GetPhysicalExaminationType();
                        doctorExaminationViewExamTypeComboBox.SelectedIndex = -1;
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
                        doctorExaminationViewCommentsResultTextBox.Enabled = false;
                        //doctorExaminationViewExamTypeComboBox.SelectedIndex = -1;
                        if (id_exam != 0)
                        {
                            var result = DoctorFacade.GetPhysicalExamination(id_exam);
                            doctorExaminationViewExamTypeComboBox.Items.Add(result[0]);
                            doctorExaminationViewExamTypeComboBox.SelectedIndex = 0;
                            doctorExaminationViewExamNameTextBox.Text = result[1];
                            doctorExaminationViewCommentsResultTextBox.Text = result[2];
                        }
                        
                    }
                    break;
            }

        }

        private void doctorExaminationViewExamTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (doctorExaminationViewExamTypeComboBox.SelectedIndex != -1)
            {
                if (doctorExaminationViewExamTypeComboBox.SelectedValue != null)
                {
                    doctorExaminationViewExamNameTextBox.Text = DoctorFacade.GetNameForExam(doctorExaminationViewExamTypeComboBox.SelectedValue.ToString());
                }
            }
            else
            {
                doctorExaminationViewExamNameTextBox.Text = "";
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

        private void doctorExaminationViewSubmitButton_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            if (doctorExaminationViewExamTypeComboBox.SelectedIndex != -1) {
                Physical_examination phyExam = new Physical_examination();
                phyExam.result = doctorExaminationViewCommentsResultTextBox.Text;
                phyExam.id_visit = id_visit;
                phyExam.code = doctorExaminationViewExamTypeComboBox.SelectedValue.ToString();
                phyExam.execution_datetime = time;
                DoctorFacade.AddPhyExam(phyExam);
                this.Close();
            } else
            {
                MessageBox.Show("No selected examination type","Error");
            }

        }

        private void doctorExaminationViewOrderButton_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            if (doctorExaminationViewExamTypeComboBox.SelectedIndex != -1)
            {
                Laboratory_examination labExam = new Laboratory_examination();
                labExam.doctor_comments = doctorExaminationViewCommentsResultTextBox.Text;
                labExam.state = "ORD";
                labExam.id_visit = id_visit;
                labExam.order_date = time;
                labExam.code = doctorExaminationViewExamTypeComboBox.SelectedValue.ToString();
                DoctorFacade.AddLabExam(labExam);
                this.Close();
            }
            else
            {
                MessageBox.Show("No selected examination type", "Error");
            }
        }
    }
}

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
        public DoctorExaminationViewForm(int id=0,string state=null)
        {
            InitializeComponent();
            SetWindowMode(-1);
            this.id_visit = id;
        }

        private void SetWindowMode(int mode)//0=LAB, 1=PHY, else=PHY_read_only
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

                      
                        dateToComboBox = new List<string>();
                        var query= DoctorFacade.GetLaboratoryExaminationType();
                        foreach (var x in query) dateToComboBox.Add( x.ToString());
                        doctorExaminationViewExamTypeComboBox.DataSource = dateToComboBox;

                      

                        

                        

                       
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
        private List<string> dateToComboBox;

        private void doctorExaminationViewOrderButton_Click(object sender, EventArgs e)
        {
            string commnet = doctorExaminationViewCommentsResultTextBox.ToString();
            DateTime _actuallTime = DateTime.Now;
            Laboratory_examination labExam = new Laboratory_examination();

            labExam.state = "ORD";
            labExam.id_visit = id_visit;
            labExam.order_date = _actuallTime;
            DoctorFacade.AddLabExam(labExam);
            this.Close();
            // TO DO dodanie do dbo.Laboratory_examination
        }
        private int id_visit = 0;
    }


}

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
using DataLayer;
namespace Clinic
{
    public partial class DoctorVisitViewForm : Form
    {
        Patient patient;
        int idVisit;
        public DoctorVisitViewForm(Patient patient, int idVisit)
        {
            InitializeComponent();
            //initialize data
            this.patient = patient;
            this.idVisit = idVisit;
            string state = DoctorFacade.GetVisitState(idVisit);
            if (!state.Equals("REG"))
            {
                doctorVisitPatientDescriptionTextBox.Enabled = false;
                doctorVisitPatientDiagnosisTextBox.Enabled = false;
                doctorPhysicalExaminationButton.Enabled = false;
                doctorLaboratoryExaminationButton.Enabled = false;
                doctorFinishVisitButton.Enabled = false;
                doctorCancelVisitButton.Enabled = false;
            }
            //this.id = patient.id_patient;
            doctorVisitPatientFirstNameTextBox.Text = patient.fname;
            doctorVisitPatientFirstNameTextBox.Enabled = false;
            doctorVisitPatientLastNameTextBox.Text = patient.lname;
            doctorVisitPatientLastNameTextBox.Enabled = false;
            doctorVisitPatientPeselTextBox.Text = patient.PESEL;
            doctorVisitPatientPeselTextBox.Enabled = false;
            doctorVisitPatientDescriptionTextBox.Text = "Description";
            doctorVisitPatientDescriptionTextBox.ForeColor = SystemColors.GrayText;
            doctorVisitPatientDiagnosisTextBox.Text = "Diagnosis";
            doctorVisitPatientDiagnosisTextBox.ForeColor = SystemColors.GrayText;
            RefreshExamGrid();
        }

        private void doctorFinishVisitButton_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            Visit visit = new Visit();
            visit.id_visit = this.idVisit;
            //sprawdzic czy nie maja czegos zlego wpisanego
            if (doctorVisitPatientDescriptionTextBox.Text != "Description") {
                visit.description = doctorVisitPatientDescriptionTextBox.Text;
            }
            if (doctorVisitPatientDiagnosisTextBox.Text != "Diagnosis") {
                visit.diagnosis = doctorVisitPatientDiagnosisTextBox.Text;
            }
            visit.state = "DONE";
            visit.execution_cancel_datetime = time;
            DoctorFacade.FinishVisit(visit);
            this.Close();
            //validate data
        }

        private void doctorPhysicalExaminationButton_Click(object sender, EventArgs e)
        {
            // refresh examination history
            //MessageBox.Show("Physical examination submited !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DoctorExaminationViewForm examinationView = new DoctorExaminationViewForm(this.idVisit, 0, 1);
            examinationView.SetPhyExamMode();
            examinationView.ShowDialog(this);
            RefreshExamGrid();
        }

        private void RefreshExamGrid()
        {
            doctorVisitViewCurrExamDataGrid.DataSource = DoctorFacade.GetExaminationsByVisit(this.idVisit);
            doctorVisitViewCurrExamDataGrid.Columns[0].HeaderText = "Code";
            doctorVisitViewCurrExamDataGrid.Columns[1].HeaderText = "Type";
            doctorVisitViewCurrExamDataGrid.Columns[2].HeaderText = "Ordered";
            doctorVisitViewCurrExamDataGrid.Columns[3].HeaderText = "State";
            doctorVisitViewCurrExamDataGrid.Columns[4].HeaderText = "Executed";
            doctorVisitViewCurrExamDataGrid.Columns[5].HeaderText = "Approved";
            doctorVisitViewCurrExamDataGrid.Columns[6].HeaderText = "Result";
            doctorVisitViewCurrExamDataGrid.Columns[7].Visible = false;
            doctorVisitViewCurrExamDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void doctorOrderLaboratoryExaminationButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Laboratory examination ordered !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoctorExaminationViewForm examinationView = new DoctorExaminationViewForm(this.idVisit);
            examinationView.SetLabExamMode();
            examinationView.ShowDialog(this);
            RefreshExamGrid();
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
                DateTime time = DateTime.Now;
                Visit visit = new Visit();
                visit.id_visit = this.idVisit;
                if (doctorVisitPatientDescriptionTextBox.Text != "Description")
                {
                    visit.description = doctorVisitPatientDescriptionTextBox.Text;
                }
                if (doctorVisitPatientDiagnosisTextBox.Text != "Diagnosis")
                {
                    visit.diagnosis = doctorVisitPatientDiagnosisTextBox.Text;
                }
                visit.state = "CANC";
                visit.execution_cancel_datetime = time;
                DoctorFacade.FinishVisit(visit);
                this.Close();
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
            if (doctorVisitViewExaminationListDataGrid.RowCount == 0 || doctorVisitViewExaminationListDataGrid.SelectedCells.Count == 0)
            {
                //MessageBox.Show("No visit selected", "Error");
                MessageBox.Show("No examination selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (doctorVisitViewExaminationListDataGrid.SelectedRows.Count > 1)
            {
                //MessageBox.Show("Selected too many visits, please select just one", "Error");
                MessageBox.Show("Selected too many examinations ! \nPlease select just one...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int examinationIndex = doctorVisitViewExaminationListDataGrid.CurrentRow.Index;
                int idExam = Int32.Parse(doctorVisitViewExaminationListDataGrid.Rows[examinationIndex].Cells[7].Value.ToString());
                if (doctorVisitViewExaminationListDataGrid.Rows[examinationIndex].Cells[1].Value.Equals("Laboratory"))
                {
                    LabolatoryExaminationForm examinationView = new LabolatoryExaminationForm(idExam);
                    examinationView.ShowDialog(this);

                }
                else
                {
                    DoctorExaminationViewForm examinationView = new DoctorExaminationViewForm(this.idVisit, idExam);
                    examinationView.ShowDialog(this);
                }

            }
        }

        private void doctorVisitViewLoadExamHistButton_Click(object sender, EventArgs e)
        {
            this.doctorVisitViewExaminationListDataGrid.DataSource = DoctorFacade.GetExamHist(patient.id_patient,idVisit);
            doctorVisitViewExaminationListDataGrid.Columns[0].HeaderText = "Code";
            doctorVisitViewExaminationListDataGrid.Columns[1].HeaderText = "Type";
            doctorVisitViewExaminationListDataGrid.Columns[2].HeaderText = "Ordered";
            doctorVisitViewExaminationListDataGrid.Columns[3].HeaderText = "State";
            doctorVisitViewExaminationListDataGrid.Columns[4].HeaderText = "Executed";
            doctorVisitViewExaminationListDataGrid.Columns[5].HeaderText = "Approved";
            doctorVisitViewExaminationListDataGrid.Columns[6].HeaderText = "Result";
            doctorVisitViewExaminationListDataGrid.Columns[7].Visible = false;
            doctorVisitViewExaminationListDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //force select first row
            if (doctorVisitViewExaminationListDataGrid.Rows.Count >= 1) doctorVisitViewExaminationListDataGrid.CurrentCell = doctorVisitViewExaminationListDataGrid.Rows[0].Cells[0];
        }

        private void doctorVisitViewLoadVisitHistButton_Click(object sender, EventArgs e)
        {
            this.doctorVisitViewVisitListDataGrid.DataSource = DoctorFacade.GetVisitsByPatient(patient.id_patient,idVisit);
            doctorVisitViewVisitListDataGrid.Columns[0].HeaderText = "Registered";
            doctorVisitViewVisitListDataGrid.Columns[1].HeaderText = "Executed/canceled";
            doctorVisitViewVisitListDataGrid.Columns[2].HeaderText = "State";
            doctorVisitViewVisitListDataGrid.Columns[3].HeaderText = "Doctor's first name";
            doctorVisitViewVisitListDataGrid.Columns[4].HeaderText = "Doctor's last name";
            doctorVisitViewVisitListDataGrid.Columns[5].Visible = false;
            doctorVisitViewVisitListDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //force select first row
            if (doctorVisitViewVisitListDataGrid.Rows.Count >= 1) doctorVisitViewVisitListDataGrid.CurrentCell = doctorVisitViewVisitListDataGrid.Rows[0].Cells[0];
        }

        private void doctorVisitViewVisitHistDetailsButton_Click(object sender, EventArgs e)
        {
            //Visit selected = null;
            if (doctorVisitViewVisitListDataGrid.RowCount == 0 || doctorVisitViewVisitListDataGrid.SelectedCells.Count == 0)
            {
                //MessageBox.Show("No visit selected", "Error");
                MessageBox.Show("No visit selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (doctorVisitViewVisitListDataGrid.SelectedRows.Count > 1)
            {
                //MessageBox.Show("Selected too many visits, please select just one", "Error");
                MessageBox.Show("Selected too many visits ! \nPlease select just one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int selectedIndex = doctorVisitViewVisitListDataGrid.CurrentRow.Index;
                int idSelected = Int32.Parse(doctorVisitViewVisitListDataGrid.Rows[selectedIndex].Cells[5].Value.ToString());
                //selected = DoctorFacade.GetVisitById(idSelected);
                VisitInfoViewForm visit = new VisitInfoViewForm(idSelected);
                visit.ShowDialog(this);
            }
        }

        private void doctorVisitViewExamDetailsButton_Click(object sender, EventArgs e)
        {
            if (doctorVisitViewCurrExamDataGrid.RowCount == 0 || doctorVisitViewCurrExamDataGrid.SelectedCells.Count == 0)
            {
                //MessageBox.Show("No visit selected", "Error");
                MessageBox.Show("No examination selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (doctorVisitViewCurrExamDataGrid.SelectedRows.Count > 1)
            {
                //MessageBox.Show("Selected too many visits, please select just one", "Error");
                MessageBox.Show("Selected too many examinations ! \nPlease select just one...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int examinationIndex = doctorVisitViewCurrExamDataGrid.CurrentRow.Index;
                int idExam = Int32.Parse(doctorVisitViewCurrExamDataGrid.Rows[examinationIndex].Cells[7].Value.ToString());
                if (doctorVisitViewCurrExamDataGrid.Rows[examinationIndex].Cells[1].Value.Equals("Laboratory"))
                {
                    LabolatoryExaminationForm examinationView = new LabolatoryExaminationForm(idExam);
                    examinationView.ShowDialog(this);
                    
                }
                else
                {
                    DoctorExaminationViewForm examinationView = new DoctorExaminationViewForm(this.idVisit,idExam);
                    examinationView.ShowDialog(this);
                }

            }
        }

        private void doctorVisitStateComboBox_SelectedIndexChanged()
        {

        }

        private void doctorVisitViewVisitListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doctorVisitViewExaminationListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //private int id = 0;
    }
}

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
        }

        private void doctorFinishVisitButton_Click(object sender, EventArgs e)
        {
            //validate data
        }

        private void doctorPhysicalExaminationButton_Click(object sender, EventArgs e)
        {
            // refresh examination history
            //MessageBox.Show("Physical examination submited !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DoctorExaminationViewForm examinationView = new DoctorExaminationViewForm(this.idVisit);
            examinationView.SetPhyExamMode();
            examinationView.ShowDialog(this);
        }

        private void doctorOrderLaboratoryExaminationButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Laboratory examination ordered !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoctorExaminationViewForm examinationView = new DoctorExaminationViewForm(this.idVisit);
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

        private void doctorVisitViewLoadExamHistButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Test");
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
            //MessageBox.Show("Test");
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

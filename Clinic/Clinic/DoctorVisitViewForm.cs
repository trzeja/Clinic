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
        public DoctorVisitViewForm()
        {
            InitializeComponent();
            //initialize data
            doctorVisitPatientDescriptionTextBox.Text = "Description";
            doctorVisitPatientDescriptionTextBox.ForeColor = SystemColors.GrayText;
        }

        private void doctorFinishVisitButton_Click(object sender, EventArgs e)
        {
            //validate data
        }

        private void doctorPhysicalExaminationButton_Click(object sender, EventArgs e)
        {
            // refresh examination history
            MessageBox.Show("Physical examination submited !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void doctorOrderLaboratoryExaminationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Laboratory examination ordered !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

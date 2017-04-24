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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            doctorTextBoxPatient.Text = "Patient";
            doctorTextBoxPatient.ForeColor = SystemColors.GrayText;
        }

        private void surnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void doctorTextBoxPatient_Click(object sender, EventArgs e)
        {
            SelectPersonForm doctorSelectPatient = new SelectPersonForm();
            doctorSelectPatient.setRegistrarAddButtonEnableDisable(false);
            doctorSelectPatient.ShowDialog(this);
        }

        private void doctorTextBoxPatient_Enter(object sender, EventArgs e)
        {
            if (doctorTextBoxPatient.Text == "Patient")
            {
                doctorTextBoxPatient.Text = "";
                doctorTextBoxPatient.ForeColor = SystemColors.WindowText;
            }
        }

        private void doctorTextBoxPatient_Leave(object sender, EventArgs e)
        {
            if (doctorTextBoxPatient.Text.Length == 0)
            {
                doctorTextBoxPatient.Text = "Patient";
                doctorTextBoxPatient.ForeColor = SystemColors.GrayText;
            }
        }

        private void doctorSearchButton_Click(object sender, EventArgs e)
        {
           // this.Controls.Add(this.dataGridViewDoctor)
        }

        private void doctorSelectVisitbutton_Click(object sender, EventArgs e)
        {
            DoctorVisitViewForm doctorViewVisit = new DoctorVisitViewForm();
            //doctorViewVisit.setDoctorVisitPatientNameDisable(true);// do dorobienia metody
            doctorViewVisit.ShowDialog(this);
        }
    }
}

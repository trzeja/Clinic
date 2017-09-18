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
    public partial class RegistrarAddVisitForm : Form
    {
        public RegistrarAddVisitForm()
        {
            InitializeComponent();
        }

        private void resgistrarAddVisitButton_Click(object sender, EventArgs e)
        {
            //add visit

            //RegistrarAddVisitDataGridView
            if (RegistrarAddVisitDataGridView.SelectedRows.Count == 1 && RegistrarAddVisitDataGridView.Rows.Count > 0)
            {
                RegistrarAddModifyForm registrarAddFrom = new RegistrarAddModifyForm();
                registrarAddFrom.setModifyTrueAddFalse(false);
                registrarAddFrom.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Select patient !", "Select row ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void registrarModifyPatientButton_Click(object sender, EventArgs e)
        {
            //modify patient
            if (RegistrarAddVisitDataGridView.SelectedRows.Count == 1 && RegistrarAddVisitDataGridView.Rows.Count > 0)
            {
                SelectPersonForm registrarSelectPatient = new SelectPersonForm("Modify", true);
                registrarSelectPatient.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Select patient !", "Select row ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RegistrarAddVisitSearchButton_Click(object sender, EventArgs e)
        {
            //search patients
            Patient search = new Patient();
            search.fname = registrarTextBoxPatientFName.Text.ToString();
            search.lname = registrarTextBoxPatientLName.Text.ToString();

            RegistrarAddVisitDataGridView.DataSource = RegistrationFacade.GetPatients(search);

        }
    }
}

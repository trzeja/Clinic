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
    public partial class RegistrarSelectPatient : Form
    {
        public RegistrarSelectPatient()
        {
            InitializeComponent();
        }

        private void registrarAddPatientButton_Click(object sender, EventArgs e)
        {
            RegistrarAddPatientForm registrarAddPatientForm = new RegistrarAddPatientForm();
            registrarAddPatientForm.ShowDialog(this);
        }

        public void setRegistrarAddButtonEnableDisable(bool set)
        {
            this.registrarAddPatientButton.Enabled = set;
        }

      
    }
}

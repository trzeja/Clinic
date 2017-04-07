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
    public partial class RegistrarAddPatientForm : Form
    {
        public RegistrarAddPatientForm()
        {
            InitializeComponent();
        }

        private void registrarAddPatientButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

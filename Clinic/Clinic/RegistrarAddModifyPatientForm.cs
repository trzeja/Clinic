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
    public partial class RegistrarAddModifyPatientForm : Form
    {
        public RegistrarAddModifyPatientForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }
        public RegistrarAddModifyPatientForm(string windowName, string buttonName)
        {
            InitializeComponent();
            InitializeTextBoxes();
            this.registrarAddPatientButtonApprove.Text = buttonName;
            this.Text = windowName;
        }

        private void registrarAddPatientButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void InitializeTextBoxes()
        {
      

        }

        private void RegistrarAddPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void registrarAddPatientButtonApprove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

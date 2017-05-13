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
            
          
        }

        private void doctorSearchButton_Click(object sender, EventArgs e)
        {
           // this.Controls.Add(this.dataGridViewDoctor)
        }

        private void doctorSelectVisitbutton_Click(object sender, EventArgs e)
        {
            DoctorVisitViewForm doctorViewVisit = new DoctorVisitViewForm();
            doctorViewVisit.ShowDialog(this);
        }

        private void doctorFindPatientButton_Click(object sender, EventArgs e)
        {
            SelectPersonForm doctorSelectPatient = new SelectPersonForm();
            doctorSelectPatient.setRegistrarAddButtonEnableDisable(false);
            doctorSelectPatient.ShowDialog(this);
        }
    }
}

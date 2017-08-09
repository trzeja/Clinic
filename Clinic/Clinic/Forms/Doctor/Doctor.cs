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
    public partial class Doctor : Form
    {
        Patient p;
        public Doctor()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            p = new Patient();

        }

        private void doctorSearchButton_Click(object sender, EventArgs e)
        {
            //this.Controls.Add(this.dataGridViewDoctor);

            Patient mockPatient = new Patient();
            mockPatient.id_patient = 1;

            Visit visitSearchCriteria = new Visit();
            visitSearchCriteria.id_patient = mockPatient.id_patient;
            visitSearchCriteria.state = doctorVisitStateComboBox.Text;
            visitSearchCriteria.registration_date = doctorDateTimePickerExecDate.Value;

            VisitFacade.GetPatientsVisits(visitSearchCriteria);
        }

        private void doctorSelectVisitbutton_Click(object sender, EventArgs e)
        {
            DoctorVisitViewForm doctorViewVisit = new DoctorVisitViewForm();
            doctorViewVisit.ShowDialog(this);
        }

        private void doctorFindPatientButton_Click(object sender, EventArgs e)
        {         
            SelectPersonForm doctorSelectPatient = new SelectPersonForm(p);            
            doctorSelectPatient.setRegistrarAddButtonEnableDisable(false);
            doctorSelectPatient.ShowDialog(this);
            this.doctorPatientNameTextBox.Text = p.lname;
        }
    }
}

using Clinic;
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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            Initialize();


        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet1.Visit' table. You can move, or remove it, as needed.
            this.visitTableAdapter.Fill(this.clinicDataSet1.Visit);

        }

        private void resgistrarAddVisitButton_Click(object sender, EventArgs e)
        {
            RegistrarAddFrom registrarAddFrom = new RegistrarAddFrom();
            registrarAddFrom.setRegistrarCancelVisitButtonEnableDisable(false);
            registrarAddFrom.ShowDialog(this);
           



        }

 

        private void Initialize()
        {
            this.registrarTextBoxPatient.ReadOnly = true;
            this.registrarTextBoxDoctor.ReadOnly = true;
            

        }

        private void registrarSearchButton_Click(object sender, EventArgs e)
        {
          
        }

        private void registrarCancelButton_Click(object sender, EventArgs e)
        {
            RegistrarAddFrom registrarmodifyVisit= new RegistrarAddFrom();
            registrarmodifyVisit.setRegistrarCancelVisitButtonEnableDisable(true);
            registrarmodifyVisit.ShowDialog(this);

        }

        private void registrarSelectPatientButton_Click(object sender, EventArgs e)
        {
            SelectPersonForm registrarSelectPatient = new SelectPersonForm();
            registrarSelectPatient.setRegistrarAddButtonEnableDisable(false);
            registrarSelectPatient.ShowDialog(this);

        }

        private void registrarSelectDoctorButton_Click(object sender, EventArgs e)
        {
            SelectPersonForm registrarSelectDoctor = new SelectPersonForm();
            registrarSelectDoctor.setRegistrarAddButtonEnableDisable(false);
            registrarSelectDoctor.ShowDialog(this);
        }
    }
}

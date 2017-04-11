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

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDPatient
        private void registrarTextBoxDoctor_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxDoctor.Text == "Doctor")
            {
                registrarTextBoxDoctor.Text = "";
                registrarTextBoxDoctor.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxDoctor_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxDoctor.Text.Length == 0)
            {
                registrarTextBoxDoctor.Text = "Doctor";
                registrarTextBoxDoctor.ForeColor = SystemColors.GrayText;
            }
           
        }

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDPatient

        private void registrarTextBoxPatient_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxPatient.Text == "Patient")
            {
                registrarTextBoxPatient.Text = "";
                registrarTextBoxPatient.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxPatient_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxPatient.Text.Length == 0)
            {
                registrarTextBoxPatient.Text = "Patient";
                registrarTextBoxPatient.ForeColor = SystemColors.GrayText;
            }
        }

        private void Initialize()
        {
            this.dataTimePickerEcCancelDate.Checked = false;

            //registrarTextBoxDoctor
            registrarTextBoxDoctor.ForeColor = SystemColors.GrayText;
            registrarTextBoxDoctor.Text = "Doctor";
            this.registrarTextBoxDoctor.Leave += new System.EventHandler(this.registrarTextBoxDoctor_Leave);
            this.registrarTextBoxDoctor.Enter += new System.EventHandler(this.registrarTextBoxDoctor_Enter);

            //registrarTextBoxPatient
            registrarTextBoxPatient.ForeColor = SystemColors.GrayText;
            registrarTextBoxPatient.Text = "Patient";
            this.registrarTextBoxPatient.Leave += new System.EventHandler(this.registrarTextBoxPatient_Leave);
            this.registrarTextBoxPatient.Enter += new System.EventHandler(this.registrarTextBoxPatient_Enter);


        }

        private void registrarSearchButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.dataGridViewRegistrar);
        }

        private void registrarCancelButton_Click(object sender, EventArgs e)
        {
            RegistrarAddFrom registrarmodifyVisit= new RegistrarAddFrom();
            //registrarmodifyVisit.setRegistrarApproveButtonEnableDisable(false);
            registrarmodifyVisit.ShowDialog(this);

        }

       

        private void registrarTextBoxPatient_Clicked(object sender, EventArgs e)
        {
            SelectPersonForm registrarSelectPatient = new SelectPersonForm();
            registrarSelectPatient.setRegistrarAddButtonEnableDisable(false);
            registrarSelectPatient.ShowDialog(this);
        }

        private void registrarTextBoxDoctor_Clicked(object sender, EventArgs e)
        {

            SelectPersonForm registrarSelectDoctor = new SelectPersonForm();
            registrarSelectDoctor.setRegistrarAddButtonEnableDisable(false);
            registrarSelectDoctor.ShowDialog(this);
        }
    }
}

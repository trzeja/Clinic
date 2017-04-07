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
            registrarAddFrom.ShowDialog(this);

        }

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDPatient
        private void registrarTextBoxDoctor_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxDoctor.Text == "ID Doctor")
            {
                registrarTextBoxDoctor.Text = "";
                registrarTextBoxDoctor.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxDoctor_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxDoctor.Text.Length == 0)
            {
                registrarTextBoxDoctor.Text = "ID Doctor";
                registrarTextBoxDoctor.ForeColor = SystemColors.GrayText;
            }
           
        }

        /*///////////////////////////////////////////////////////////////////////*/
        //registrarTextBoxIDPatient

        private void registrarTextBoxPatient_Enter(object sender, EventArgs e)
        {
            if (registrarTextBoxPatient.Text == "ID Patient")
            {
                registrarTextBoxPatient.Text = "";
                registrarTextBoxPatient.ForeColor = SystemColors.WindowText;
            }
        }

        private void registrarTextBoxPatient_Leave(object sender, EventArgs e)
        {
            if (registrarTextBoxPatient.Text.Length == 0)
            {
                registrarTextBoxPatient.Text = "ID Patient";
                registrarTextBoxPatient.ForeColor = SystemColors.GrayText;
            }
        }

        private void Initialize()
        {
            this.dataTimePickerEcCancelDate.Checked = false;

            //registrarTextBoxDoctor
            registrarTextBoxDoctor.ForeColor = SystemColors.GrayText;
            registrarTextBoxDoctor.Text = "ID Doctor";
            this.registrarTextBoxDoctor.Leave += new System.EventHandler(this.registrarTextBoxDoctor_Leave);
            this.registrarTextBoxDoctor.Enter += new System.EventHandler(this.registrarTextBoxDoctor_Enter);

            //registrarTextBoxPatient
            registrarTextBoxPatient.ForeColor = SystemColors.GrayText;
            registrarTextBoxPatient.Text = "ID Patient";
            this.registrarTextBoxPatient.Leave += new System.EventHandler(this.registrarTextBoxPatient_Leave);
            this.registrarTextBoxPatient.Enter += new System.EventHandler(this.registrarTextBoxPatient_Enter);


        }

        private void registrarSearchButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.dataGridViewRegistrar);
        }
    }
}

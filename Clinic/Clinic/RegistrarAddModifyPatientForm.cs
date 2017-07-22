using BizzLayer;
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
        private Patient _patient;
        public Patient Patient { get; set; }

        public RegistrarAddModifyPatientForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }
        public RegistrarAddModifyPatientForm(string windowName, string buttonName, Patient patient = null)
        {
            _patient = patient;
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
            if (_patient != null)
            {
                peselBox.Text = _patient.PESEL;
                fnameBox.Text = _patient.fname;
                lnameBox.Text = _patient.lname;
                placeBox.Text = _patient.Address.place;
                streetBox.Text = _patient.Address.street;
                zipCodeBox.Text = _patient.Address.zip_code;
            }            
            
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

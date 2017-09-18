using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using BizzLayer.Facades;
using DataLayer;

namespace Clinic
{
    public partial class RegistrarAddModifyPatientForm : Form
    {
        private int id_patient = 0;

        public RegistrarAddModifyPatientForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }


        public RegistrarAddModifyPatientForm(string windowName, string buttonName, string id = null, string fname = null, string lname = null, string pesel = null, string place = null, string street = null, string zipcode = null, string house = null, string flat = null)
        {
            InitializeComponent();
            InitializeTextBoxes();
            this.registrarAddPatientButtonApprove.Text = buttonName;
            this.Text = windowName;
            if (id != null)
            {
                id_patient = Int32.Parse(id);
                this.peselBox.Text = pesel;
                this.fnameBox.Text = fname;
                this.lnameBox.Text = lname;
                this.placeBox.Text = place;
                this.streetBox.Text = street;
                this.zipCodeBox.Text = zipcode;
                this.houseBox.Text = house;
                this.flatBox.Text = flat;

            }
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
            Patient patientSearchCriteria;
            Address address = new Address();
            patientSearchCriteria = new Patient();
            patientSearchCriteria.id_patient = id_patient;
            patientSearchCriteria.PESEL = this.peselBox.Text.ToString();
            patientSearchCriteria.fname = this.fnameBox.Text.ToString();
            patientSearchCriteria.lname = this.lnameBox.Text.ToString();

            address.id_patient = id_patient;
            address.place = this.placeBox.Text.ToString();
            address.street = this.streetBox.Text.ToString();
            address.zip_code = this.zipCodeBox.Text.ToString();
            address.house = this.houseBox.Text.ToString();
            address.flat = this.flatBox.Text.ToString();
            RegistrationFacade.updatePatientData(patientSearchCriteria);
            RegistrationFacade.updateAdressData(address);

            this.Close();
        }
    }
}

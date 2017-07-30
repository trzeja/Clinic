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


        public RegistrarAddModifyPatientForm(string windowName, string buttonName, string pesel = null, string fname = null, string lname = null, string place = null, string street = null, string zipcode = null,string house=null,string flat=null)
        {
            InitializeComponent();
            InitializeTextBoxes();
            this.registrarAddPatientButtonApprove.Text = buttonName;
            this.Text = windowName;
            if (pesel != null)
            {
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
            this.Close();
        }
    }
}

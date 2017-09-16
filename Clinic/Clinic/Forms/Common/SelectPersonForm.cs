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
using DataLayer;
using BizzLayer.Facades;

namespace Clinic
{
    public partial class SelectPersonForm : Form
    {
        private bool modifyTrueAddFalse;
        private List<string> dataFromGrid = new List<string>();
        private enum index { ID = 0, FNAME, LNAME, PESEL, PLACE, STREET, ZIPCODE, HOUSE, FLAT };
        public SelectPersonForm()
        {
            InitializeComponent();
            // InitializeTextBoxes();
        }
        public SelectPersonForm(string buttonName, bool modifyTrueAddFalse)
        {
            InitializeComponent();
            // InitializeTextBoxes();
            this.registrarModifyButton.Enabled = modifyTrueAddFalse;
            this.modifyTrueAddFalse = modifyTrueAddFalse;
            this.registrarModifyButton.Text = buttonName;

            if (modifyTrueAddFalse == true)
            {
                this.registrarSelectButton.Text = "Confirm";
            }
            else this.registrarSelectButton.Text = "Select";
        }


        private void registrarAddPatientButton_Click(object sender, EventArgs e)
        {

            try
            {


                modifyData();
                RegistrarAddModifyPatientForm registrarAddPatientForm = new RegistrarAddModifyPatientForm("Modify Patient", "Confirm", dataFromGrid[(int)index.ID], dataFromGrid[(int)index.FNAME], dataFromGrid[(int)index.LNAME], dataFromGrid[(int)index.PESEL],
                                                                                                            dataFromGrid[(int)index.PLACE], dataFromGrid[(int)index.STREET], dataFromGrid[(int)index.ZIPCODE]);
                registrarAddPatientForm.ShowDialog(this);
                refreshGrid();
            }

            catch
            {
                ;
            }
        }

        public void setRegistrarAddButtonEnableDisable(bool set)
        {
            this.registrarModifyButton.Enabled = set;
        }


        //fnameTextbox
        private void fnameTextbox_Leave(object sender, EventArgs e)
        {
            if (fnameTextbox.Text.Length == 0)
            {
                fnameTextbox.Text = "First Name";
                fnameTextbox.ForeColor = SystemColors.GrayText;
            }
        }

        private void fnameTextbox_Enter(object sender, EventArgs e)
        {
            if (fnameTextbox.Text == "First Name")
            {
                fnameTextbox.Text = "";
                fnameTextbox.ForeColor = SystemColors.WindowText;
            }
        }
        /*///////////////////////////////////////////////////////////////////////*/
        //lnameTextbox
        private void lnameTextbox_Leave(object sender, EventArgs e)
        {
            if (lnameTextbox.Text.Length == 0)
            {
                lnameTextbox.Text = "Last Name";
                lnameTextbox.ForeColor = SystemColors.GrayText;
            }
        }


        private void lnameTextbox_Enter(object sender, EventArgs e)
        {
            if (lnameTextbox.Text == "Last Name")
            {
                lnameTextbox.Text = "";
                lnameTextbox.ForeColor = SystemColors.WindowText;
            }
        }
        private void InitializeTextBoxes()
        {
            //fnameTextbox
            fnameTextbox.ForeColor = SystemColors.GrayText;
            fnameTextbox.Text = "First Name";
            this.fnameTextbox.Leave += new System.EventHandler(this.fnameTextbox_Leave);
            this.fnameTextbox.Enter += new System.EventHandler(this.fnameTextbox_Enter);

            //lnameTextbox
            lnameTextbox.ForeColor = SystemColors.GrayText;
            lnameTextbox.Text = "Last Name";
            this.lnameTextbox.Leave += new System.EventHandler(this.lnameTextbox_Leave);
            this.lnameTextbox.Enter += new System.EventHandler(this.lnameTextbox_Enter);

        }

        private void registrarSelectButton_Click(object sender, EventArgs e)
        {
            modifyData();
        }


        private void modifyData()
        {
            dataFromGrid.Clear();

            try
            {

                int curRowIndex = dataGridView1.CurrentCell.RowIndex;
                string tmpID = null;
                Patient patientSearchCriteria = new Patient();
                Address addressSearchCriteria = new Address();

                if (dataGridView1.Rows[curRowIndex].Cells[0].Value == null) throw new Exception();

                tmpID = dataGridView1.Rows[curRowIndex].Cells[0].Value.ToString();
                int id = Int32.Parse(tmpID);

                patientSearchCriteria.id_patient = id;
                addressSearchCriteria.id_patient = id;


                Patient patient = RegistrationFacade.GetPatientByID(patientSearchCriteria);
                Address address = RegistrationFacade.GetAdressByID(addressSearchCriteria);
                if (patient == null) throw new Exception();


                dataFromGrid.Add(tmpID);
                dataFromGrid.Add(patient.fname.ToString());
                dataFromGrid.Add(patient.lname.ToString());
                dataFromGrid.Add(patient.PESEL.ToString());

                if (address != null)
                {
                    dataFromGrid.Add(address.place.ToString());
                    dataFromGrid.Add(address.street.ToString());
                    dataFromGrid.Add(address.zip_code.ToString());
                    dataFromGrid.Add(address.house.ToString());
                    dataFromGrid.Add(address.flat.ToString());
                }



            }
            catch
            {
                MessageBox.Show("No data !", "ERROR!");
            }

            this.Close();
        }

        private void registrarSearchButton_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            Patient patientSearchCriteria;
            patientSearchCriteria = new Patient();
            patientSearchCriteria.fname = fnameTextbox.Text.ToString();
            patientSearchCriteria.lname = lnameTextbox.Text.ToString();
            dataGridView1.DataSource = RegistrationFacade.GetPatientsWithAdresses(patientSearchCriteria);
        }


        //gettery

        public string getLname()
        {
            return dataFromGrid[(int)index.LNAME];
        }

        public string getID()
        {
            return dataFromGrid[(int)index.ID];
        }
    }



}

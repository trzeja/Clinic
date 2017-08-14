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
            InitializeTextBoxes();
        }
        public SelectPersonForm(string buttonName, bool modifyTrueAddFalse)
        {
            InitializeComponent();
            InitializeTextBoxes();
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
            dataFromGrid.Clear();
            if (modifyTrueAddFalse == false)
            {

                RegistrarAddModifyPatientForm registrarAddPatientForm = new RegistrarAddModifyPatientForm("Add Patient", "Add");
                registrarAddPatientForm.ShowDialog(this);
            }
            else
            {
                try
                {

                    int curRowIndex = dataGridView1.CurrentCell.RowIndex;
                    // var dataFromGrid = new List<string>();
                    string tmpValue = null;


                    for (int col = 0; col < dataGridView1.Rows[curRowIndex].Cells.Count; col++)
                    {
                        if (dataGridView1.Rows[curRowIndex].Cells[col].Value == null) continue;
                        tmpValue = dataGridView1.Rows[curRowIndex].Cells[col].Value.ToString();
                        dataFromGrid.Add(tmpValue);
                    }


                    while (dataFromGrid.Count < dataGridView1.Rows[curRowIndex].Cells.Count) dataFromGrid.Add(null);

                    RegistrarAddModifyPatientForm registrarAddPatientForm = new RegistrarAddModifyPatientForm("Modify Patient", "Confirm", dataFromGrid[(int)index.ID], dataFromGrid[(int)index.FNAME], dataFromGrid[(int)index.LNAME], dataFromGrid[(int)index.PESEL],
                                                                                                                dataFromGrid[(int)index.PLACE], dataFromGrid[(int)index.STREET], dataFromGrid[(int)index.ZIPCODE]);
                    registrarAddPatientForm.ShowDialog(this);
                    refreshGrid();
                }
                catch
                {
                    MessageBox.Show("Kaj mosz parametry :D ?", "ERROR!");
                }

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
            dataFromGrid.Clear();

            try
            {

                int curRowIndex = dataGridView1.CurrentCell.RowIndex;

                string tmpValue = null;


                for (int col = 0; col < dataGridView1.Rows[curRowIndex].Cells.Count; col++)
                {
                    if (dataGridView1.Rows[curRowIndex].Cells[col].Value == null) continue;
                    tmpValue = dataGridView1.Rows[curRowIndex].Cells[col].Value.ToString();
                    dataFromGrid.Add(tmpValue);
                }


                while (dataFromGrid.Count < dataGridView1.Rows[curRowIndex].Cells.Count) dataFromGrid.Add(null);




            }
            catch
            {
                MessageBox.Show("Kaj mosz parametry :D ?", "ERROR!");
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
            //patientSearchCriteria.lname = "Kowalski";
            //patientSearchCriteria.lname = lnameTextbox.Text;

            // ładowanie obiektu dataGridView
            //  dataGridView1.Columns.Clear();
            // dataGridView1.AutoGenerateColumns = true;
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

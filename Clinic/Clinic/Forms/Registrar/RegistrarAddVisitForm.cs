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
using DataLayer;


namespace Clinic
{
    public partial class RegistrarAddVisitForm : Form
    {

        private enum index { ID = 0, FNAME, LNAME, PESEL, PLACE, STREET, ZIPCODE, HOUSE, FLAT };
        public RegistrarAddVisitForm()
        {
            InitializeComponent();
        }

        private void resgistrarAddVisitButton_Click(object sender, EventArgs e)
        {
            //add visit

            //RegistrarAddVisitDataGridView
            if (RegistrarAddVisitDataGridView.SelectedRows.Count == 1 && RegistrarAddVisitDataGridView.Rows.Count > 0)
            {
                int curRowIndex = RegistrarAddVisitDataGridView.CurrentCell.RowIndex;

                int IdPatient = Int32.Parse(RegistrarAddVisitDataGridView.Rows[curRowIndex].Cells[0].Value.ToString());

               // var name = RegistrarAddVisitDataGridView.Rows[curRowIndex].Cells[2].Value.ToString();

                RegistrarAddModifyForm registrarAddFrom = new RegistrarAddModifyForm(IdPatient);
                registrarAddFrom.setModifyTrueAddFalse(false);
                registrarAddFrom.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Select patient !", "Select row ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void registrarModifyPatientButton_Click(object sender, EventArgs e)
        {
            //modify patient
            if (RegistrarAddVisitDataGridView.SelectedRows.Count == 1 && RegistrarAddVisitDataGridView.Rows.Count > 0)
            {
                int curRowIndex = RegistrarAddVisitDataGridView.CurrentCell.RowIndex;
                List<string> dataFromGrid = new List<string>();

                for (int i = 0; i < 9; i++)
                {
                    dataFromGrid.Add(RegistrarAddVisitDataGridView.Rows[curRowIndex].Cells[i].Value.ToString());
                }

                RegistrarAddModifyPatientForm registrarSelectPatient = new RegistrarAddModifyPatientForm("Modify Patient", "Confirm", dataFromGrid[(int)index.ID], dataFromGrid[(int)index.FNAME], dataFromGrid[(int)index.LNAME], dataFromGrid[(int)index.PESEL],
                                                                                                            dataFromGrid[(int)index.PLACE], dataFromGrid[(int)index.STREET], dataFromGrid[(int)index.ZIPCODE], dataFromGrid[(int)index.HOUSE], dataFromGrid[(int)index.FLAT]);
                registrarSelectPatient.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Select patient !", "Select row ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RegistrarAddVisitSearchButton_Click(object sender, EventArgs e)
        {
            //search patients
            Patient search = new Patient();
            search.fname = registrarTextBoxPatientFName.Text.ToString();
            search.lname = registrarTextBoxPatientLName.Text.ToString();

            RegistrarAddVisitDataGridView.DataSource = RegistrationFacade.GetPatientsWithAdresses(search);

            //force select first row
            if (RegistrarAddVisitDataGridView.Rows.Count >= 1) RegistrarAddVisitDataGridView.CurrentCell = RegistrarAddVisitDataGridView.Rows[0].Cells[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarAddModifyPatientForm registrarSelectPatient = new RegistrarAddModifyPatientForm();
            registrarSelectPatient.ShowDialog(this);
        }
    }
}

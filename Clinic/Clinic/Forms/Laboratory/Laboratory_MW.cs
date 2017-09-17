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
    public partial class Laboratory_MW : Form
    {
        private string roles, username;

        public Laboratory_MW()
        {
            InitializeComponent();
            Initialize();
            disable_all();
        }

        public Laboratory_MW(string roles, string username)
        {
            InitializeComponent();
            Initialize();
            this.roles = roles;
            this.username = username;
            if (roles.Equals("LABM"))
            {
                Text = "Laboratory Manager";
                labMWComboboxState.Text = "DONE";
            }
            else if (roles.Equals("LABW"))
            {
                Text = "Laboratory Worker";
                labMWComboboxState.Text = "ORD";
            }
            else
            {
                disable_all();
            }
        }

        private void disable_all()
        {
            labMWShowButton.Enabled = false;
            labMWEditButton.Enabled = false;
            labMWComboboxState.Enabled = false;
            labMWDataTimePickerOrderDate.Enabled = false;
        }

        private void labManagerShowButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.labMWDataGridView);
            BizzLayer.Laboratory_examination searchCriteria;
            searchCriteria = new BizzLayer.Laboratory_examination();
            if (labMWDataTimePickerOrderDate.Checked) searchCriteria.order_date = labMWDataTimePickerOrderDate.Value;
            else searchCriteria.order_date = DateTime.MinValue;
            searchCriteria.state = labMWComboboxState.Text;
            labMWDataGridView.DataSource = BizzLayer.Facades.LaboratoryFacade.GetExaminations(searchCriteria);
            labMWDataGridView.Columns[0].Visible = false;//id examination
            labMWDataGridView.Columns[1].HeaderText = "Order date";
            labMWDataGridView.Columns[2].HeaderText = "Execution date";
            labMWDataGridView.Columns[3].HeaderText = "Approval date";
            labMWDataGridView.Columns[4].Visible = false;
            labMWDataGridView.Columns[5].Visible = false;
            labMWDataGridView.Columns[6].Visible = false;
            labMWDataGridView.Columns[7].HeaderText = "State";
            labMWDataGridView.Columns[8].Visible = false;
            labMWDataGridView.Columns[9].Visible = false;
            labMWDataGridView.Columns[10].Visible = false;
            labMWDataGridView.Columns[11].Visible = false;
            labMWDataGridView.Columns[12].Visible = false;
            labMWDataGridView.Columns[13].Visible = false;
            labMWDataGridView.Columns[14].Visible = false;
            labMWDataGridView.Columns[15].Visible = false;

            labMWDataGridView.ClearSelection();// żeby nie było problemow pozniej
        }

        private void Initialize()
        {
          
        }

        private void labManagerEditButton_Click(object sender, EventArgs e)
        {
            if (labMWDataGridView.SelectedRows.Count == 1 && labMWDataGridView.Rows.Count > 0)
            {
                
                //kzp : do przekazania proponuję id_laboraory_examination i username
                int tmp_id_exam = (int)labMWDataGridView.CurrentRow.Cells[0].Value; //kzp: tutaj id zaznaczonego badania 
                string tmp_username = username; //kzp: tutaj username zalogowanego usera - potem można wyszukać w odpowiedniej tabeli jego id
                //LabolatoryExaminationForm labExamView = new LabolatoryExaminationForm(tmp_id_exam, username); //kzp: tak to mogloby wygladac a reszte danych u siebie se pobierzesz

                LabolatoryExaminationForm labExamView = new LabolatoryExaminationForm(); 
                labExamView.SetLabManagerMode();
                labExamView.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Select laboratory examination !", "Select row ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Laboratory_MW_Resize(object sender, EventArgs e)
        {
            labMWEditButton.Location = new Point(
                Width - 137,
                Height - 69                
              );
            labMWDataGridView.Height = 235 - 400 + Height;
        }
    }
}

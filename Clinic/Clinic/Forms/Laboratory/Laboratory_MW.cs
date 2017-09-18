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
    public partial class Laboratory_MW : Form
    {
        private string roles, username;
        int? id_worker = null;
        int? id_manager = null;

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
            if (roles.Equals("LABW"))
            {
                id_worker = BizzLayer.Facades.LaboratoryFacade.GetWorkerIdByUsername( username );
            }
            else if (roles.Equals("LABM"))
            {
                id_manager = BizzLayer.Facades.LaboratoryFacade.GetManagerIdByUsername( username );
            }
            if (id_manager != null || id_worker != null)
            {
                //this.username = username;
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
                    MessageBox.Show("Wrong role !\nPlease try to log in again or contact administrator", "Wrong role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                disable_all();
                MessageBox.Show("Your ID does not exist !\nPlease try to log in again or contact administrator", "Wrong ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DataLayer.Laboratory_examination searchCriteria;
            searchCriteria = new DataLayer.Laboratory_examination();
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
                int tmp_id_exam = (int)labMWDataGridView.CurrentRow.Cells[0].Value; // id zaznaczonego badania w gridzie

                if (roles.Equals("LABM"))
                {
                    // roles -> rola czyli "LABM" lub "LABW", id_worker -> id managera z "Laboratory_manager", username - user_name z "User"
                    //LabolatoryExaminationForm labExamView = new LabolatoryExaminationForm(roles, id_manager, username, tmp_id_exam);
                    LabolatoryExaminationForm labExamView = new LabolatoryExaminationForm();
                    labExamView.SetLabManagerMode();
                    labExamView.ShowDialog(this);
                }
                else if (roles.Equals("LABW"))
                {
                    // roles -> rola czyli "LABM" lub "LABW", id_worker -> id workera z "Laboratory_worker", username - user_name z "User"
                    //LabolatoryExaminationForm labExamView = new LabolatoryExaminationForm(roles, id_worker, username, tmp_id_exam);
                    LabolatoryExaminationForm labExamView = new LabolatoryExaminationForm();
                    labExamView.SetLabManagerMode();
                    labExamView.ShowDialog(this);
                }                
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

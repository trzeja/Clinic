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
using BizzLayer.Facades;
using DataLayer;
namespace Clinic
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.clinicDataSet.User);

        }
        
        private void adminEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridAdmin.SelectedRows.Count == 1 && dataGridAdmin.Rows.Count > 0)
            {
                User user = null;
                //CurrentRow nie bedzie nigdy nullem bo jest pierwsze wybrane 
                //bedzie nullem! trzeba sprawdzic
                int userIndex = dataGridAdmin.CurrentRow.Index;
                string username = dataGridAdmin.Rows[userIndex].Cells[0].Value.ToString();
                user = CommonFacade.GetUserByUsername(username);

                AdminEditForm adminEditForm = new AdminEditForm("Edit user", "Confirm", true, user);
                adminEditForm.ShowDialog(this);

                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Select user !", "Select row ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void adminAddButton_Click(object sender, EventArgs e)
        {
            AdminEditForm adminAddForm = new AdminEditForm("Add user", "Confirm", true, null);
            adminAddForm.ShowDialog(this);
            RefreshGrid();
        }
                
        private void adminSearchButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            //force select first row
            if (dataGridAdmin.Rows.Count >= 1) dataGridAdmin.CurrentCell = dataGridAdmin.Rows[0].Cells[0];
        }
        
        private void RefreshGrid()
        {

            User userSearchCriteria = new User();
            userSearchCriteria.fname = adminTextBoxFirstName.Text;
            userSearchCriteria.lname = adminTextBoxLastName.Text;
            userSearchCriteria.roles = comboBox1.Text;
            if (dataTimePickerRegDate.Checked)
            {
                userSearchCriteria.retire_date = dataTimePickerRegDate.Value;
            }
            else
            {
                userSearchCriteria.retire_date = null;
            }
            //jeśli nie jest zaznaczony, to chyba null, trzeba przy logowaniu sprawdzać
            //czy nie ma już tej daty
            //dlaczego to tutaj a nie gdzie indziej
            dataGridAdmin.Visible = true;

            dataGridAdmin.DataSource = AdminFacade.GetUsers(userSearchCriteria);
            dataGridAdmin.Columns[0].HeaderText = "Username";
            dataGridAdmin.Columns[0].DisplayIndex = 0;
            dataGridAdmin.Columns[1].Visible = false;
            dataGridAdmin.Columns[1].DisplayIndex = 5;
            //dataGridAdmin.Columns[1].HeaderText = "Password";

            dataGridAdmin.Columns[3].HeaderText = "Role";
            dataGridAdmin.Columns[3].DisplayIndex = 3;

            dataGridAdmin.Columns[5].HeaderText = "User first name";
            dataGridAdmin.Columns[5].DisplayIndex = 1;

            dataGridAdmin.Columns[4].HeaderText = "User last name";
            dataGridAdmin.Columns[4].DisplayIndex = 2;

            dataGridAdmin.Columns[2].HeaderText = "Retire date";
            dataGridAdmin.Columns[2].DisplayIndex = 4;
            dataGridAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

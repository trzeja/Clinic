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

namespace Clinic
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
           
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.clinicDataSet.User);

        }

        private void dataGridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void adminEditButton_Click(object sender, EventArgs e)
        {

            AdminEditForm adminAddForm = new AdminEditForm("Edit user", "Confirm", true);
            adminAddForm.ShowDialog(this);

        }

        private void adminAddButton_Click(object sender, EventArgs e)
        {
            AdminEditForm adminAddForm = new AdminEditForm("Add user", "Confirm", true);
            adminAddForm.ShowDialog(this);
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //czy nie powinna się zmienić nazwa na adminSearchButton? 
        private void registrarSearchButton_Click(object sender, EventArgs e)
        {
            User userSearchCriteria;
            userSearchCriteria = new User();
            userSearchCriteria.fname = adminTextBoxFirstName.Text;
            userSearchCriteria.lname = adminTextBoxLastName.Text;
            userSearchCriteria.roles = comboBox1.Text;
            if (dataTimePickerRegDate.Checked)
            {
                userSearchCriteria.retire_date = dataTimePickerRegDate.Value;
            }
            this.Controls.Add(this.dataGridAdmin);
            dataGridAdmin.DataSource = AdminFacade.GetUsers(userSearchCriteria);
            dataGridAdmin.Columns[0].Visible = false;
            dataGridAdmin.Columns[1].Visible = false;
            dataGridAdmin.Columns[2].HeaderText = "Retire date";
            dataGridAdmin.Columns[3].HeaderText = "Role";
            dataGridAdmin.Columns[4].HeaderText = "User last name";
            dataGridAdmin.Columns[5].HeaderText = "User first name";
            
        }

        private void initializeElements()
        {
            ;
        }
    }
}

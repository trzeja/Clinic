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
            //czy tu powinniśmy pokazywać od razu w formularzu?
            //chyba nie, bo możemy mieć niepasujące kryterium
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


        }

        private void initializeElements()
        {
            ;
        }
    }
}

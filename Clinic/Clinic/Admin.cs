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
            AdminEditForm adminEditForm = new AdminEditForm();
            adminEditForm.setValue("Modify", true);
            adminEditForm.ShowDialog(this);

        }

        private void adminAddButton_Click(object sender, EventArgs e)
        {
            AdminEditForm adminAddForm = new AdminEditForm();
            adminAddForm.ShowDialog(this);
            adminAddForm.setValue("Add", false);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registrarSearchButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.dataGridAdmin);
        }

        private void initializeElements()
        {
            ;
        }
    }
}

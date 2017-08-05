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
    public partial class AdminEditForm : Form
    {
        private bool modifyTrueAddFalse;
        public AdminEditForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
            this.Name = "AdminAddForm";
            this.Text = "Add user";


        }

        public AdminEditForm(string windowName, string buttonName, bool modifyTrueAddFalse)
        {
            InitializeComponent();
            InitializeTextBoxes();
            this.Name = windowName;
            this.Text = windowName;
            this.modifyTrueAddFalse = modifyTrueAddFalse;
            this.adminModifyButton.Text = buttonName;
        }


        private void InitializeTextBoxes()
        {
           
            this.ActiveControl = adminModifyButton;



        }

        private void adminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void setValue(string text,bool modifyTrueAddFalse)
        {
            this.modifyTrueAddFalse = modifyTrueAddFalse;
            this.adminModifyButton.Text = text;
        }

        private void adminModifyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


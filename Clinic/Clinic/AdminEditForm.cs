﻿using System;
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
        public AdminEditForm()
        {
            InitializeComponent();
        }

        private void adminCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminApproveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
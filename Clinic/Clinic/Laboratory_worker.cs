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
    public partial class Laboratory_worker : Form
    {
        public Laboratory_worker()
        {
            InitializeComponent();
            Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labWorkerApproveButton_Click(object sender, EventArgs e)
        {

        }

        private void labWorkerShowButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.dataGridLabWorker);
            this.labWorkerCancelButton.Enabled = true;
            this.labWorkerApproveButton.Enabled = true;

        }

        private void Initialize()
        {
            this.labWorkerCancelButton.Enabled = false;
            this.labWorkerApproveButton.Enabled = false;
        }
    }
}

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
    public partial class Laboratory_worker_editForm : Form
    {
        public Laboratory_worker_editForm()
        {
            InitializeComponent();
        }

        private void labWorkerEConfirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Laboratory_manager : Form
    {
        public Laboratory_manager()
        {
            InitializeComponent();
            Initialize();


        }

         
private void labManagerShowButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.dataGridViewLabManager);
            labManagerCancelButton.Enabled = true;
            labManagerApproveButton.Enabled = true;
        }

        private void Initialize()
        {
            labManagerCancelButton.Enabled = false;
            labManagerApproveButton.Enabled = false;
        }
    }
}

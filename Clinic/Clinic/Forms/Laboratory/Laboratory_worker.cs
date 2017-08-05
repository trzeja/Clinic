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

        private void labWorkerEditButton_Click(object sender, EventArgs e)
        {
            //Laboratory_worker_editForm labEditForm = new Laboratory_worker_editForm();
            //labEditForm.ShowDialog(this);
            LabolatoryExaminationForm labExamView = new LabolatoryExaminationForm();
            labExamView.SetLabWorkerMode();
            labExamView.ShowDialog(this);
        }

        private void labWorkerShowButton_Click(object sender, EventArgs e)
        {
            
           
            this.labWorkerEditButton.Enabled = true;

        }

        private void Initialize()
        {
            
            this.labWorkerEditButton.Enabled = false;
        }
    }
}

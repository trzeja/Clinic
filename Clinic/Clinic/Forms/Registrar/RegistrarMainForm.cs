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
    public partial class RegistrarMainForm : Form
    {
        public RegistrarMainForm()
        {
            InitializeComponent();
        }

        private void RegistratarMainFormAddVisitButton_Click(object sender, EventArgs e)
        {
            //nowa formatka
            RegistrarAddVisitForm addVisits = new RegistrarAddVisitForm();
            addVisits.ShowDialog(this);
        }

        private void RegistratarMainFormManageVisitsButton_Click(object sender, EventArgs e)
        {
            //stara po reworku
            RegistrarManageVisitsForm manageVisits = new RegistrarManageVisitsForm();
            manageVisits.ShowDialog(this);

        }
    }
}

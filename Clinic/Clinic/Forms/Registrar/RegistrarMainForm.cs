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
        private int? id_reg;
        public RegistrarMainForm( string reg_username )
        {
            id_reg = BizzLayer.Facades.RegistrationFacade.GetRegIdByUsername(reg_username);
            InitializeComponent();
            if (id_reg == null)
            {
                MessageBox.Show("Your id_registration does not exist !\nPlease try to log in again or contact administrator", "Wrong ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistratarMainFormAddVisitButton.Enabled = false;
                RegistratarMainFormManageVisitsButton.Enabled = false;
            }
        }

        private void RegistratarMainFormAddVisitButton_Click(object sender, EventArgs e)
        {
            //add visit aka patient grid form

            // w id_reg (int) jest id rejetratorki - potrzebne do przekazania jeśli robimy add visit
            //RegistrarAddVisitForm addVisits = new RegistrarAddVisitForm( id_reg );
            RegistrarAddVisitForm addVisits = new RegistrarAddVisitForm(id_reg);
            addVisits.ShowDialog(this);
        }

        private void RegistratarMainFormManageVisitsButton_Click(object sender, EventArgs e)
        {
            //manage visit aka visit grid form
            // nie wiem czy tu będzie potrzebne ale ...
            // w id_reg (int) jest id rejetratorki - potrzebne do przekazania jeśli robimy add visit
            RegistrarManageVisitsForm manageVisits = new RegistrarManageVisitsForm();
            manageVisits.ShowDialog(this);

        }
    }
}

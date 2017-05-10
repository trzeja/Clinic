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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Admin adminForm = new Admin();
            adminForm.Show();
            Registrar registrarForm = new Registrar();
            registrarForm.Show();
            Laboratory_worker laboratory_worker = new Laboratory_worker();
            laboratory_worker.Show();
            Laboratory_manager laboratory_manager = new Laboratory_manager();
            laboratory_manager.Show();
            Doctor doctor = new Doctor();
            doctor.Show();
        }
    }
}

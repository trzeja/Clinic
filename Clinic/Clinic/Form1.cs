using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;//do md5
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

            //Registrar registrarForm = new Registrar();
            //registrarForm.Show();
            //Doctor doctor = new Doctor();
            //doctor.Show();
            //Laboratory_worker laboratory_worker = new Laboratory_worker();
            //laboratory_worker.Show();
            //Laboratory_manager laboratory_manager = new Laboratory_manager();
            //laboratory_manager.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // skrót hasła i pozostała magia
            loginUsernameTextBox.Text = MD5Hash(loginPasswordTextBox.Text);// to tylko przykład/do testowania
        }
        public string MD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));//X2 = upper-case, x2 = lower-case
            }

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer.Facades;
using BizzLayer;
using DataLayer;
using System.Security.Cryptography;//do md5
using BizzLayer.Services;

namespace Clinic
{
    public partial class LoginForm : Form
    {
        public Doctor doctor;
        public Registrar registrarForm;
        public Admin adminForm;
        public Laboratory_worker laboratory_worker;
        public Laboratory_manager laboratory_manager;
        public LoginForm()
        {
            InitializeComponent();
            // loginUsernameTextBox.Text = MD5Hash(loginPasswordTextBox.Text);// to tylko przykład/do testowania
            //registrarForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //data from BizzLayer
            User userSearchCriteria = new User();
            userSearchCriteria.user_name = loginTextBox.Text;
            IQueryable<User> resultRecords = UserFacade.GetUser(userSearchCriteria);

            //próba dobicia sie do stringa z haslem
            Seed s = new Seed();
            string passwordLogin = CryptoService.MD5Hash(passwordTextBox.Text);
            var passwordSQL = resultRecords.FirstOrDefault().password;
            if (object.Equals(passwordSQL, passwordLogin))
            {
                if (resultRecords.Where(a => a.roles == "DOC").Any())
                {
                    doctor = new Doctor();
                    doctor.Show();                   
                }
                else if (resultRecords.Where(a => a.roles == "REG").Any())
                {
                    registrarForm = new Registrar();
                    registrarForm.Show();
                }
                else if (resultRecords.Where(a => a.roles == "LABM").Any())
                {
                    laboratory_manager = new Laboratory_manager();
                    laboratory_manager.Show();
                }
                else if (resultRecords.Where(a => a.roles == "LABW").Any())
                {
                    laboratory_worker = new Laboratory_worker();
                    laboratory_worker.Show();
                }
                else if (resultRecords.Where(a => a.roles == "ADM").Any())
                {
                    adminForm = new Admin();
                    adminForm.Show();
                }
            }
            else MessageBox.Show("Wrong login or password");
           
        }


        //hashowanie
        //public string MD5Hash(string input)
        //{
        //    MD5 md5 = System.Security.Cryptography.MD5.Create();
        //    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        //    byte[] hash = md5.ComputeHash(inputBytes);
        //    StringBuilder sb = new StringBuilder();

        //    for (int i = 0; i < hash.Length; i++)
        //    {
        //        sb.Append(hash[i].ToString("X2"));//X2 = upper-case, x2 = lower-case
        //    }

        //    return sb.ToString();
        //}
    }
}

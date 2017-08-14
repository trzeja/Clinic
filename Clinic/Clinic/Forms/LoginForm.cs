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

            //User userSearchCriteria = new User();
            //userSearchCriteria.user_name = loginTextBox.Text;
            //IQueryable<User> resultRecords = UserFacade.GetUser(userSearchCriteria);
            User user = CommonFacade.GetUserByUsername(loginTextBox.Text);
            //próba dobicia sie do stringa z haslem
            if (user != null) {
                string passwordLogin = CryptoService.MD5Hash(passwordTextBox.Text);
                //var passwordSQL = resultRecords.FirstOrDefault().password;
                if (object.Equals(user.password, passwordLogin))
                {
                    if (user.retire_date == null
                        || user.retire_date.Value < DateTime.Now.Date)
                    {
                        if (user.roles == "DOC")
                        {
                            doctor = new Doctor();
                            doctor.Show();
                        }
                        else if (user.roles == "REG")
                        {
                            registrarForm = new Registrar();
                            registrarForm.Show();
                        }
                        else if (user.roles == "LABM")
                        {
                            laboratory_manager = new Laboratory_manager();
                            laboratory_manager.Show();
                        }
                        else if (user.roles == "LABW")
                        {
                            laboratory_worker = new Laboratory_worker();
                            laboratory_worker.Show();
                        }
                        else if (user.roles == "ADM")
                    {
                            adminForm = new Admin();
                            adminForm.Show();
                        }
                    }
                    else MessageBox.Show("Can't access account because of retire date. Contact administrator");
                }
                else MessageBox.Show("Wrong login or password");
            }
            else MessageBox.Show("Wrong login");
           
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

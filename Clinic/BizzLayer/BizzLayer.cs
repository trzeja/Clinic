using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Security.Cryptography;

namespace BizzLayer
{
    static public class RegistrationFacade
    {
        public static IQueryable<Patient> GetPatients(Patient searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Patients
                      where
                      (String.IsNullOrEmpty(searchCrit.lname) || el.lname.StartsWith(searchCrit.lname))
                      &&
                      ((searchCrit.id_patient == 0) || el.id_patient == searchCrit.id_patient)
                      // && inne ...
                      select el;
            return res;
        }
    }

    static public class UserFacade
    {
        public static IQueryable<User> GetUser(User searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Users
                      where

                      (el.user_name.Equals(searchCrit.user_name))
                      // && inne ...
                      select el;

            return res;
        }
    }



    public class Seed
    {

        public void SeedDatabse()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();


            User u = new User();
            u.user_name = "doc";
            u.password = MD5Hash("doc");
            u.fname = "Jan";
            u.lname = "Kowalski";
            u.roles = "DOC";

            if (!dc.Users.Contains(u))
                dc.Users.InsertOnSubmit(u);

            User u1 = new User();
            u1.user_name = "admin";
            u1.password = MD5Hash("admin");
            u1.fname = "Jan";
            u1.lname = "Kowalski";
            u1.roles = "ADM";

            if (!dc.Users.Contains(u1))
                dc.Users.InsertOnSubmit(u1);


            User u2 = new User();
            u2.user_name = "reg";
            u2.password = MD5Hash("reg");
            u2.fname = "Jan";
            u2.lname = "Kowalski";
            u2.roles = "REG";

            if (!dc.Users.Contains(u2))
                dc.Users.InsertOnSubmit(u2);

            User u3 = new User();
            u3.user_name = "labm";
            u3.password = MD5Hash("labm");
            u3.fname = "Jan";
            u3.lname = "Kowalski";
            u3.roles = "LABM";

            if (!dc.Users.Contains(u3))
                dc.Users.InsertOnSubmit(u3);

            User u4 = new User();
            u4.user_name = "labw";
            u4.password = MD5Hash("labw");
            u4.fname = "Jan";
            u4.lname = "Kowalski";
            u4.roles = "LABW";

            if (!dc.Users.Contains(u4))
                dc.Users.InsertOnSubmit(u4);

            Doctor d = new Doctor();
            d.id_doc = 1;
            d.user_name = "doc";

            if (!dc.Doctors.Contains(d))
                dc.Doctors.InsertOnSubmit(d);

            Patient p = new Patient();
            p.id_patient = 1;
            p.fname = "Jan";
            p.lname = "Kowalski";
            p.PESEL = "12345678901";

            if (!dc.Patients.Contains(p))
                dc.Patients.InsertOnSubmit(p);



            dc.SubmitChanges();
        }

        private string MD5Hash(string input)
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

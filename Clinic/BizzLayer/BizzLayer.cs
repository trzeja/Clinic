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
            //DataClasses1DataContext dc = new DataClasses1DataContext();
            //var res = from el in dc.Patients
            //          where
            //          (String.IsNullOrEmpty(searchCrit.lname) || el.lname.StartsWith(searchCrit.lname))
            //          &&
            //          ((searchCrit.id_patient == 0) || el.id_patient == searchCrit.id_patient)
            //          // && inne ...
            //          select el;

            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from patients in dc.Patients
                      join adresses in dc.Addresses on patients.id_patient equals adresses.id_patient
                      where
                      (String.IsNullOrEmpty(searchCrit.lname) || patients.lname.StartsWith(searchCrit.lname))

                      select patients;
            return res;
        }

        public static IQueryable<registrarVisitView> GetVisits(registrarVisitView searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.registrarVisitViews
                      where
                      (String.IsNullOrEmpty(searchCrit.doctorFname) || el.doctorFname.StartsWith(searchCrit.doctorFname))
                      &&
                      (String.IsNullOrEmpty(searchCrit.doctorLname) || el.doctorLname.StartsWith(searchCrit.doctorLname))
                      &&
                      (String.IsNullOrEmpty(searchCrit.patientFname) || el.patientFname.StartsWith(searchCrit.patientFname))
                      &&
                      (String.IsNullOrEmpty(searchCrit.patientFname) || el.patientFname.StartsWith(searchCrit.patientFname))
                      &&
                      (String.IsNullOrEmpty(searchCrit.state) || el.state.StartsWith(searchCrit.state))
                      &&
                      ((searchCrit.registration_date.CompareTo(DateTime.MinValue) == 0) || (el.registration_date.Year == searchCrit.registration_date.Year) && (el.registration_date.Month == searchCrit.registration_date.Month) && (el.registration_date.Day == searchCrit.registration_date.Day))
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
            d.medical_right_no = "qw3rtyu10p";

            if (!dc.Doctors.Contains(d))
                dc.Doctors.InsertOnSubmit(d);

            Patient p = new Patient();
            p.id_patient = 1;
            p.fname = "Jan";
            p.lname = "Kowalski";
            p.PESEL = "12345678901";

            if (!dc.Patients.Contains(p))
                dc.Patients.InsertOnSubmit(p);

            Registration r = new Registration();
            r.id_registration = 1;
            r.user_name = "reg";

            if (!dc.Registrations.Contains(r))
                dc.Registrations.InsertOnSubmit(r);

            Visit v1 = new Visit();
            v1.id_visit = 2;
            v1.id_registration = 1;
            v1.id_patient = 1;
            v1.id_doctor = 1;
            v1.description = "qwer";
            v1.diagnosis = "asdf";
            v1.state = "REGISTERED";
            v1.registration_date = new DateTime(2017, 07, 20);

            Visit v2 = new Visit();
            v2.id_visit = 3;
            v2.id_registration = 1;
            v2.id_patient = 1;
            v2.id_doctor = 1;
            v2.description = "qwer";
            v2.diagnosis = "asdf";
            v2.state = "CANCELED";
            v2.registration_date = new DateTime(2017, 07, 5);
            v2.execution_cancel_datetime = new DateTime(2017, 07, 1);

            Visit v3 = new Visit();
            v3.id_visit = 4;
            v3.id_registration = 1;
            v3.id_patient = 1;
            v3.id_doctor = 1;
            v3.description = "qwer";
            v3.diagnosis = "asdf";
            v3.state = "DONE";
            v3.registration_date = new DateTime(2017, 07, 15);

            if (!dc.Visits.Contains(v1))
                dc.Visits.InsertOnSubmit(v1);
            if (!dc.Visits.Contains(v2))
                dc.Visits.InsertOnSubmit(v2);
            if (!dc.Visits.Contains(v3))
                dc.Visits.InsertOnSubmit(v3);

            dc.SubmitChanges();
        }
    }
}

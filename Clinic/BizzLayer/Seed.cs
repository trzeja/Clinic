using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzLayer
{
    public class Seed
    {
        public string MD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
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

            int index_reg = 0, index_doc = 0;

            SeedUsers(dc);
            SeedPatients(dc);
            SeedRegistrations(dc, ref index_reg);
            SeedDoctors(dc, ref index_doc);
            try
            {
                SeedVisits(dc, ref index_reg, ref index_doc);
            }
            catch (Exception)
            {
                throw;
                //zcos zwalone z tymi indexami i kluczami prywatnymi,
                //moze trzeba patient i users tak samo traktowac jak doc np
            }
        }

        private void SeedUsers(DataClasses1DataContext dc)
        {
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
        }

        public void SeedPatients(DataClasses1DataContext dc)
        {
            var patientsIdsOfCurrentPatients = from el in dc.Patients
                                               select el.id_patient;

            if (patientsIdsOfCurrentPatients.Any())
            {
                //do not add
            }
            else
            {
                Patient p = new Patient();
                //p.id_patient = 1;
                p.fname = "Jan";
                p.lname = "Kowalski";
                p.PESEL = "12345678901";

                if (!dc.Patients.Any((b => b.PESEL == p.PESEL)))
                    dc.Patients.InsertOnSubmit(p);
            }
        }

        private void SeedRegistrations(DataClasses1DataContext dc, ref int index_reg)
        {
            var registrationIdsOfCurrentRegistrars = from el in dc.Registrations
                                                     where el.user_name.Equals("reg")
                                                     select el.id_registration;

            if (registrationIdsOfCurrentRegistrars.Any())
            {
                index_reg = registrationIdsOfCurrentRegistrars.First();
            }
            else
            {
                Registration r = new Registration();
                // r.id_registration = index;
                r.user_name = "reg";

                if (!dc.Registrations.Contains(r))
                    dc.Registrations.InsertOnSubmit(r);
            }
        }

        private void SeedDoctors(DataClasses1DataContext dc, ref int index_doc)
        {
            var doctorIdsOfCurrentDoctors = from el in dc.Doctors
                                            where el.user_name.Equals("doc")
                                            select el.id_doc;

            if (doctorIdsOfCurrentDoctors.Any())
            {
                index_doc = doctorIdsOfCurrentDoctors.First();
            }
            else
            {
                Doctor d = new Doctor();
                //d.id_doc = index_doc;
                d.user_name = "doc";
                d.medical_right_no = "qw3rtyu10p";

                if (!dc.Doctors.Contains(d))
                    dc.Doctors.InsertOnSubmit(d);
            }
            dc.SubmitChanges();
        }

        private void SeedVisits(DataClasses1DataContext dc, ref int index_reg, ref int index_doc)
        {
            //var visitIdsOfCurrentVisits = from el in dc.Visits
            //                              select el.id_visit;

            //if (visitIdsOfCurrentVisits.Any())
            //{
            //    //do not add
            //}
            //else
            //{
            Visit v1 = new Visit();
           // v1.id_visit = 2;
            v1.id_registration = index_reg;
            v1.id_patient = 1;
            v1.id_doctor = index_doc;
            v1.description = "qwer";
            v1.diagnosis = "asdf";
            v1.state = "REGISTERED";
            v1.registration_date = new DateTime(2017, 07, 20);

            Visit v2 = new Visit();
           // v2.id_visit = 3;
            v2.id_registration = index_reg;
            v2.id_patient = 1;
            v2.id_doctor = index_doc;
            v2.description = "qwer";
            v2.diagnosis = "asdf";
            v2.state = "CANCELED";
            v2.registration_date = new DateTime(2017, 07, 5);
            v2.execution_cancel_datetime = new DateTime(2017, 07, 1);

            Visit v3 = new Visit();
           // v3.id_visit = 4;
            v3.id_registration = index_reg;
            v3.id_patient = 1;
            v3.id_doctor = index_doc;
            v3.description = "qwer";
            v3.diagnosis = "asdf";
            v3.state = "DONE";
            v3.registration_date = new DateTime(2017, 07, 15);

            if (dc.Patients.Any(b => b.id_patient == v1.id_patient) && dc.Doctors.Any(b => b.id_doc == v1.id_doctor) && dc.Registrations.Any(b => b.id_registration == v1.id_registration))
                dc.Visits.InsertOnSubmit(v1);

            if (dc.Patients.Any(b => b.id_patient == v2.id_patient) && dc.Doctors.Any(b => b.id_doc == v2.id_doctor) && dc.Registrations.Any(b => b.id_registration == v2.id_registration))
                dc.Visits.InsertOnSubmit(v2);

            if (dc.Patients.Any(b => b.id_patient == v3.id_patient) && dc.Doctors.Any(b => b.id_doc == v3.id_doctor) && dc.Registrations.Any(b => b.id_registration == v3.id_registration))
                dc.Visits.InsertOnSubmit(v3);



            //if (!dc.Visits.Contains(v1))
            //    dc.Visits.InsertOnSubmit(v1);
            //if (!dc.Visits.Contains(v2))
            //    dc.Visits.InsertOnSubmit(v2);
            //if (!dc.Visits.Contains(v3))
            //    dc.Visits.InsertOnSubmit(v3);

            dc.SubmitChanges();
            //}
        }
    }
    }

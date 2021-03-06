﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzLayer.Services;
using BizzLayer.Model;

using DataLayer;

namespace BizzLayer.Services
{
    public class Seed
    {
        public void SeedDatabse()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            int index_reg = 0, index_doc = 0, index_pat = 0, index_labm = 0, index_labw = 0;

            SeedUsers(dc);
            SeedPatients(dc, ref index_pat);
            SeedAddresses(dc, ref index_pat);
            SeedRegistrations(dc, ref index_reg);
            SeedDoctors(dc, ref index_doc);
            SeedLaboratoryManagers(dc, ref index_labm);
            SeedLaboratoryWorkers(dc, ref index_labw);
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
            u.password = CryptoService.MD5Hash("doc");
            u.fname = "Jan";
            u.lname = "Kowalski";
            u.roles = "DOC";

            if (!dc.Users.Contains(u))
                dc.Users.InsertOnSubmit(u);

            User u1 = new User();
            u1.user_name = "admin";
            u1.password = CryptoService.MD5Hash("admin");
            u1.fname = "Jan";
            u1.lname = "Kowalski";
            u1.roles = "ADM";

            if (!dc.Users.Contains(u1))
                dc.Users.InsertOnSubmit(u1);


            User u2 = new User();
            u2.user_name = "reg";
            u2.password = CryptoService.MD5Hash("reg");
            u2.fname = "Jan";
            u2.lname = "Kowalski";
            u2.roles = "REG";

            if (!dc.Users.Contains(u2))
                dc.Users.InsertOnSubmit(u2);

            User u3 = new User();
            u3.user_name = "labm";
            u3.password = CryptoService.MD5Hash("labm");
            u3.fname = "Jan";
            u3.lname = "Kowalski";
            u3.roles = "LABM";

            if (!dc.Users.Contains(u3))
                dc.Users.InsertOnSubmit(u3);

            User u4 = new User();
            u4.user_name = "labw";
            u4.password = CryptoService.MD5Hash("labw");
            u4.fname = "Jan";
            u4.lname = "Kowalski";
            u4.roles = "LABW";

            if (!dc.Users.Contains(u4))
                dc.Users.InsertOnSubmit(u4);

            dc.SubmitChanges();
        }

        public void SeedPatients(DataClasses1DataContext dc, ref int index_pat)
        {
            var patientsIdsOfCurrentPatients = from el in dc.Patients
                                               select el.id_patient;

            if (patientsIdsOfCurrentPatients.Any())
            {
                index_pat = patientsIdsOfCurrentPatients.First();
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

                dc.SubmitChanges();
            }

        }

        private void SeedAddresses(DataClasses1DataContext dc, ref int index_pat)
        {
            var addressIdsOfCurrentAddresses = from el in dc.Addresses
                                               select el.id_patient;
            if (addressIdsOfCurrentAddresses.Any())
            {
                //nothing
            }
            else
            {
                Address a = new Address
                {
                    id_patient = index_pat,
                    place = "Sikornik",
                    street = "Drozdow",
                    zip_code = "44-100",
                    house = "21",
                    flat = "13"
                };

                dc.Addresses.InsertOnSubmit(a);
            }
        }

        private void SeedLaboratoryWorkers(DataClasses1DataContext dc, ref int index_labw)
        {
            var labwIdsOfCurrentLabws = from el in dc.Laboratory_workers
                                        where el.user_name.Equals("labw")
                                        select el.id_laboratory_worker;
            if (labwIdsOfCurrentLabws.Any())
            {
                index_labw = labwIdsOfCurrentLabws.First();
            }
            else
            {
                Laboratory_worker labw = new Laboratory_worker();
                labw.user_name = "labw";
                dc.Laboratory_workers.InsertOnSubmit(labw);
                dc.SubmitChanges();
            }
        }

        private void SeedLaboratoryManagers(DataClasses1DataContext dc, ref int index_labm)
        {
            var labmIdsOfCurrentLabms = from el in dc.Laboratory_managers
                                        where el.user_name.Equals("labm")
                                        select el.id_laboratory_manager;
            if (labmIdsOfCurrentLabms.Any())
            {
                index_labm = labmIdsOfCurrentLabms.First();
            }
            else
            {
                Laboratory_manager labm = new Laboratory_manager();
                labm.user_name = "labm";
                dc.Laboratory_managers.InsertOnSubmit(labm);
                dc.SubmitChanges();
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

                //if (!dc.Registrations.Contains(r))
                dc.Registrations.InsertOnSubmit(r);
                dc.SubmitChanges();
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

                //if (!dc.Doctors.Contains(d))
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
            v1.state = Consts.visitStateRegistered;
            v1.registration_date = new DateTime(2017, 07, 20);

            Visit v2 = new Visit();
            // v2.id_visit = 3;
            v2.id_registration = index_reg;
            v2.id_patient = 1;
            v2.id_doctor = index_doc;
            v2.description = "qwer";
            v2.diagnosis = "asdf";
            v2.state = Consts.visitStateCancelled;
            v2.registration_date = new DateTime(2017, 07, 5);
            v2.execution_cancel_datetime = new DateTime(2017, 07, 1);

            Visit v3 = new Visit();
            // v3.id_visit = 4;
            v3.id_registration = index_reg;
            v3.id_patient = 1;
            v3.id_doctor = index_doc;
            v3.description = "qwer";
            v3.diagnosis = "asdf";
            v3.state = Consts.visitStateDone;
            v3.registration_date = new DateTime(2017, 07, 15);

            //if (dc.Patients.Any(b => b.id_patient == v1.id_patient) && dc.Doctors.Any(b => b.id_doc == v1.id_doctor) && dc.Registrations.Any(b => b.id_registration == v1.id_registration))
            //    dc.Visits.InsertOnSubmit(v1);

            //if (dc.Patients.Any(b => b.id_patient == v2.id_patient) && dc.Doctors.Any(b => b.id_doc == v2.id_doctor) && dc.Registrations.Any(b => b.id_registration == v2.id_registration))
            //    dc.Visits.InsertOnSubmit(v2);

            //if (dc.Patients.Any(b => b.id_patient == v3.id_patient) && dc.Doctors.Any(b => b.id_doc == v3.id_doctor) && dc.Registrations.Any(b => b.id_registration == v3.id_registration))
            //    dc.Visits.InsertOnSubmit(v3);

            addVisit(v1, dc);
            addVisit(v2, dc);
            addVisit(v3, dc);

            //if (!dc.Visits.Contains(v1))
            //    dc.Visits.InsertOnSubmit(v1);
            //if (!dc.Visits.Contains(v2))
            //    dc.Visits.InsertOnSubmit(v2);
            //if (!dc.Visits.Contains(v3))
            //    dc.Visits.InsertOnSubmit(v3);

            dc.SubmitChanges();
            //}
        }

        private void addVisit(Visit v1, DataClasses1DataContext dc)
        {
            if (dc.Patients.Any(b => b.id_patient == v1.id_patient) && dc.Doctors.Any(b => b.id_doc == v1.id_doctor) && dc.Registrations.Any(b => b.id_registration == v1.id_registration))
            {

                if (!(dc.Visits.Any(x => x.id_patient == v1.id_patient &&  x.id_doctor == v1.id_doctor &&  x.description == v1.description && 
                     x.registration_date == v1.registration_date &&  x.state == v1.state)))
                {
                    dc.Visits.InsertOnSubmit(v1);

                }

            }
            dc.SubmitChanges();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BizzLayer.Facades
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

        public static IQueryable GetPatientsWithAdresses(Patient searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from p in dc.Patients
                      where ((String.IsNullOrEmpty(searchCrit.fname) || p.fname.StartsWith(searchCrit.fname)) && (String.IsNullOrEmpty(searchCrit.lname) || p.lname.StartsWith(searchCrit.lname)))
                      join ad in dc.Addresses on p.id_patient equals ad.id_patient
                      into joined
                      from j in joined.DefaultIfEmpty()


                      select new { p.id_patient, p.fname, p.lname, p.PESEL, p.Address.place, p.Address.street, p.Address.zip_code, p.Address.house, p.Address.flat };
            return res;
        }

        public static void updatePatientData(Patient patient)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from p in dc.Patients
                      where p.id_patient == patient.id_patient
                      select p;
            res.FirstOrDefault().PESEL = patient.PESEL;
            res.FirstOrDefault().fname = patient.fname;
            res.FirstOrDefault().lname = patient.lname;
            dc.SubmitChanges();
        }
        public static void updateAdressData(Address address)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from ad in dc.Addresses
                      where ad.id_patient == address.id_patient
                      select ad;

            res.FirstOrDefault().place = address.place;
            res.FirstOrDefault().street = address.street;
            res.FirstOrDefault().zip_code = address.zip_code;
            res.FirstOrDefault().house = address.house;
            res.FirstOrDefault().flat = address.flat;
            dc.SubmitChanges();
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

        public static void AddVisit(Visit v1)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            if (dc.Patients.Any(b => b.id_patient == v1.id_patient) && dc.Doctors.Any(b => b.id_doc == v1.id_doctor) && dc.Registrations.Any(b => b.id_registration == v1.id_registration))
            {

                if (!(dc.Visits.Any(x => x.id_patient == v1.id_patient && x.id_doctor == v1.id_doctor && x.description == v1.description &&
                     x.registration_date == v1.registration_date && x.state == v1.state)))
                {
                    dc.Visits.InsertOnSubmit(v1);

                }

            }
            dc.SubmitChanges();
        }

        public static void updateVisit(Visit searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Visits
                      where el.id_visit.Equals(searchCrit.id_visit)

                      select el;
            res.FirstOrDefault().state = searchCrit.state;
            res.FirstOrDefault().execution_cancel_datetime = null;
            res.FirstOrDefault().registration_date = searchCrit.registration_date;
            res.FirstOrDefault().execution_cancel_datetime = searchCrit.execution_cancel_datetime;
            // res.FirstOrDefault().id_doctor = searchCrit.id_doctor;


            dc.SubmitChanges();

        }

        public static Patient GetPatientByID(Patient searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from p in dc.Patients
                      where (p.id_patient == searchCrit.id_patient)
                      select p;
            return res.FirstOrDefault();

        }

        public static Address GetAdressByID(Address searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from ad in dc.Addresses
                      where (ad.id_patient == searchCrit.id_patient)
                      select ad;
            return res.FirstOrDefault();
            
        }

        public static void setCancelStatus(int id)
        {
            DateTime? date = DateTime.Today;
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from v in dc.Visits
                      where (v.id_visit == id)
                      select v;
            res.FirstOrDefault().state = "CANC";
            res.FirstOrDefault().execution_cancel_datetime = date;
            dc.SubmitChanges();

        }

        public static int? GetRegIdByUsername(string username)//get id_reg of given username
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from p in dc.Registrations
                      where ( p.user_name.Equals( username ) )
                      select p;
            Registration tmp = res.FirstOrDefault();
            if ( tmp != null )
            {
                return res.FirstOrDefault().id_registration;
            }
            else
            {
                return null;
            }
        }

        public static void AddPatient(Patient p)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            dc.Patients.InsertOnSubmit(p);

            dc.SubmitChanges();

        }


        public static void AddAdress(Address a)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            dc.Addresses.InsertOnSubmit(a);

            dc.SubmitChanges();

        }


        //public static void updateVisit(Visit visit)
        //{
        //    DataClasses1DataContext dc = new DataClasses1DataContext();
        //    var res = from v in dc.Visits
        //              where (v.id_visit == visit.id_visit)
        //              select v;
        //    res.FirstOrDefault().registration_date = visit.registration_date;
        //    res.FirstOrDefault().state = visit.state;

        //    dc.SubmitChanges();

        //}
    }
}

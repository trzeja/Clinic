using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                      join ad in dc.Addresses on p.id_patient equals ad.id_patient
                      into joined
                      from j in joined.DefaultIfEmpty()

                      select new { p.id_patient, p.fname, p.lname, p.PESEL, p.Address.place, p.Address.street, p.Address.zip_code, p.Address.house, p.Address.flat };
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
}

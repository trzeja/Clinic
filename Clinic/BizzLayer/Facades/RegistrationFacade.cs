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

        public static void AddVisit(Visit searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            dc.Visits.InsertOnSubmit(searchCrit);
            dc.SubmitChanges();
        }

        public static void ModifyVisit(Visit searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Visits
                      where el.id_visit.Equals(searchCrit.id_visit)

                      select el;
            res.FirstOrDefault().state = searchCrit.state;

            dc.SubmitChanges();

        }

    }
}

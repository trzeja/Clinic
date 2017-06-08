using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

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
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BizzLayer.Facades
{
    static public class DoctorFacade
    {
        public static IQueryable GetPatientsWithAdresses(Patient patient, Visit visit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from p in dc.Patients
                      join v in dc.Visits on p.id_patient equals v.id_patient
                      into joined
                      from j in joined.DefaultIfEmpty()
                      where ((j.state == visit.state && j.id_patient == patient.id_patient) && (visit.registration_date <= j.registration_date))
                      select new { p.fname, p.lname, p.PESEL, j.state, j.registration_date };
            return res;


        }
    }
}

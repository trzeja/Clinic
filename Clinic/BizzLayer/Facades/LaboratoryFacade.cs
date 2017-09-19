using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BizzLayer.Facades
{
    static public class LaboratoryFacade
    {
        public static void UpdateExaminationM(Laboratory_examination labEx)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from ex in dc.Laboratory_examinations
                         where ex.id_laboratory_examination == labEx.id_laboratory_examination
                         select ex;
            var examination = result.FirstOrDefault();
            examination.examination_approval_date = labEx.examination_approval_date;
            examination.state = labEx.state;
            examination.lab_manager_comments = labEx.lab_manager_comments;
            examination.id_laboratory_manager = labEx.id_laboratory_manager;
            dc.SubmitChanges();
        }

        public static void UpdateExamination(Laboratory_examination labEx)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from ex in dc.Laboratory_examinations
                         where ex.id_laboratory_examination == labEx.id_laboratory_examination
                         select ex;
            var examination = result.FirstOrDefault();
            examination.examination_execution_date = labEx.examination_execution_date;
            examination.state = labEx.state;
            examination.result = labEx.result;
            examination.id_laboratory_woker = labEx.id_laboratory_woker;
            dc.SubmitChanges();
        }

        public static IQueryable<DataLayer.Laboratory_examination> GetExaminations(DataLayer.Laboratory_examination searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from el in dc.Laboratory_examinations
                      where
                      ((searchCrit.order_date.CompareTo(DateTime.MinValue) == 0) || (el.order_date.Year == searchCrit.order_date.Year) && (el.order_date.Month == searchCrit.order_date.Month) && (el.order_date.Day == searchCrit.order_date.Day))
                      &&
                      (String.IsNullOrEmpty(searchCrit.state) || el.state.StartsWith(searchCrit.state))
                      select el;
            return res;
        }

        public static int? GetWorkerIdByUsername(string username)//get id of given username
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from p in dc.Laboratory_workers
                      where (p.user_name.Equals(username))
                      select p;
            Laboratory_worker tmp = res.FirstOrDefault();
            if (tmp != null)
            {
                return res.FirstOrDefault().id_laboratory_worker;
            }
            else
            {
                return null;
            }
        }

        public static int? GetManagerIdByUsername(string username)//get id of given username
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var res = from p in dc.Laboratory_managers
                      where (p.user_name.Equals(username))
                      select p;
            Laboratory_manager tmp = res.FirstOrDefault();
            if (tmp != null)
            {
                return res.FirstOrDefault().id_laboratory_manager;
            }
            else
            {
                return null;
            }
        }
    }
}

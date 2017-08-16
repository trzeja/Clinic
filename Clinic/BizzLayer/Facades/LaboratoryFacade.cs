using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzLayer.Facades
{
    static public class LaboratoryFacade
    {
        public static IQueryable<BizzLayer.Laboratory_examination> GetExaminations(BizzLayer.Laboratory_examination searchCrit)
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
    }
}

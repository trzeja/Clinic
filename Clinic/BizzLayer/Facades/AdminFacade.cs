using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzLayer.Facades
{
    //operacje na bazie danych dla admina
    //AdminEditForm - czy przy Add nie powinno być też loginu do podania?
    static public class AdminFacade
    {
        public static IQueryable<User> GetUsers(User searchCrit)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from element in dc.Users
                             //where
                             //(String.IsNullOrEmpty(searchCrit.lname) || element.lname.StartsWith(searchCrit.lname))
                             //&&
                             //(String.IsNullOrEmpty(searchCrit.fname) || element.fname.StartsWith(searchCrit.fname))
                         select element;
            return result;
        }
    }
}

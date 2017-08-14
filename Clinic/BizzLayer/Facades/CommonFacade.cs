using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzLayer.Facades
{
    static public class CommonFacade
    {
        public static User GetUserByUsername(String username)
        {
            // TODO 
            // czy nie powinnam sprawdzac zanim go wybiore czy jeszcze istnieje w bazie?
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var result = from element in dc.Users
                         where element.user_name.Equals(username)
                         select element;
            return result.FirstOrDefault();
        }
    }
}

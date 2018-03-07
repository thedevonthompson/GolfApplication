using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApp
{
    public class DBHelper
    {
        public static User GetUserByUsername(string username)
        {
            //create golf database context
            var db = new GolfDB();

            //search for user.  user will be set to null if not found
            User user = db.Users.Where(u => u.Username == username).SingleOrDefault();

            return user;
        }
        
    }
}

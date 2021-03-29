using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class UserService
    {
        UserDao userdb;

        public UserService()
        {
            userdb = new UserDao();
        }

        public User GetUser(string username, string password)
        {
            User user = userdb.GetUser(username, password);
            return user;
        }
    }
}

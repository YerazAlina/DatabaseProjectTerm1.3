using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class RegisterService
    {
        RegisterDao regdb;

        public RegisterService()
        {
            regdb = new RegisterDao();
        }


        public void AddUsertodb(User user)
        {
            regdb.AddNewUser(user);
        }
    }
}

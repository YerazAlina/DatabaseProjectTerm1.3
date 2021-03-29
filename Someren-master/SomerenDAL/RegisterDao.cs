using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class RegisterDao : BaseDao
    {
        public void AddNewUser(User user)
        {
            string queryUser = $"INSERT INTO [Users] (username, password, adminStatus, secretQuestion, secretAnswer) Values ( '{user.Username}','{user.Password}', 'user', '{user.SecretQuestion}', '{user.SecretAnswer}') ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(queryUser, sqlParameters);
        }
    }
}

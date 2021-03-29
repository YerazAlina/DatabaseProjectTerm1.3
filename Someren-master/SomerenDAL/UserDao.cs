using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class UserDao : BaseDao
    {
        public User GetUser(string username, string password)
        {
            string query = $"SELECT username, password, adminStatus, secretQuestion, secretAnswer FROM [Users] WHERE username = '{username}' AND password = '{password}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<User> users = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (users.Count == 0)
            {
                return null;
            }
            else
            {
                return users[0];
            }
        }

        public User GetUserByUsername(string username)
        {
            string query = $"SELECT username, password, adminStatus, secretQuestion, secretAnswer FROM [Users] WHERE username = '{username}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<User> users = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (users.Count == 0)
            {
                return null;
            }
            else
            {
                return users[0];
            }
        }

        public void UpdateUserPassword(string password, string username)
        {
            string query = $"UPDATE [Users] SET password='{password}' WHERE username='{username}' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<User> ReadTables(DataTable dataTable)
        {
            List<User> users = new List<User>();

            foreach (DataRow dr in dataTable.Rows)
            {
                User user = new User();

                user.Username = (string)(dr["username"]);
                user.Password = (string)(dr["password"]);
                user.AdminStatus = (string)(dr["adminStatus"]);
                user.SecretQuestion = (string)(dr["secretQuestion"]);
                user.SecretAnswer = (string)(dr["secretAnswer"]);

                users.Add(user);
            }

            return users;
        }
    }
}

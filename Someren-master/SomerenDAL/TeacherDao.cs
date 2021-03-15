using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {

        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT personID, firstName, lastName, supervisor  FROM [Person] JOIN Teachers ON Person.PersonID = Teachers.TeacherID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Number = (int)dr["personID"],
                    FirstName = (string)(dr["firstName"].ToString()),
                    LastName = (string)(dr["lastName"].ToString()),
                    Supervisor = (string)(dr["supervisor"])
                    //BirthDate = (DateTime)(dr["birthDate"])

                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}

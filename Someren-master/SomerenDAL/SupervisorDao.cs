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
    public class SupervisorDao : BaseDao
    {
        public List<Supervisor> GetAllSupervisor(int activityID)
        {
            string query = $"select firstName, teacherID, activityID FROM [TeacherActivity] " +
                $"join Person on teacherID=personID WHERE activityID = {activityID}";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Supervisor> ReadTable(DataTable dataTable)
        {
            throw new NotImplementedException();
        }

        public List<Supervisor> GetAllSupervisors(int activityID)
        {
            throw new NotImplementedException();
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor supervisor = new Supervisor()
                {
                    SupervisorName = (string)(dr["firstName"].ToString()),
                    TeacherID = (int)dr["teacherID"],
                    ActivityID = (int)dr["activityID"],
                };
                supervisors.Add(supervisor);
            }
            return supervisors;
        }

        public void AddSupervisor(Supervisor supervisor)
        {
            string query = $"INSERT INTO [TeacherActivity] (teacherID, activityID) VALUES ({supervisor.TeacherID},{supervisor.ActivityID})";// in teacher class add property to activiid
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

        }

        public void Removesupervisor(Supervisor supervisor)
        {
            string query = $"DELETE FROM [TeacherActivity] WHERE teacherID = {supervisor.TeacherID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

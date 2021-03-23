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
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT activityID, description, startDateTime, endDateTime FROM [Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityId = (int)dr["activityID"],
                    Description = (string)(dr["description"].ToString()),
                    StartTime = (DateTime)(dr["startDateTime"]),
                    EndDate = (DateTime)dr["endDateTime"]
                };

                activities.Add(activity);
            }
            return activities;
        }

        public void AddActivity(Activity a)
        {
            string query = $"INSERT INTO [Activity] (activityID, description, startDateTime, endDateTime) Values ( {a.ActivityId},'{a.Description}', {a.StartTime.ToString("yyyy-MM-dd HH:mm:ss")}, {a.EndDate.ToString("yyyy-MM-dd HH:mm:ss")}) ";
            SqlParameter[] sqlParameters = new SqlParameter[0];                                                     //startDate.ToString("yyyy-MM-dd HH:mm:ss")

            //Console.WriteLine(query);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateActivity(Activity a)
        {
            string query = $"UPDATE [Activity] SET description ='{a.Description}', startDateTime ='{a.StartTime.ToString("yyyy-MM-dd HH:mm:ss")}', endDateTime ={a.EndDate.ToString("yyyy-MM-dd HH:mm:ss")} WHERE activityID ='{a.ActivityId}' ";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveActivity(Activity a)
        {
            string query = $"DELETE FROM [Activity] WHERE activityID ='{a.ActivityId.ToString("yyyy-MM-dd HH:mm:ss")}' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);

        }

    }
}

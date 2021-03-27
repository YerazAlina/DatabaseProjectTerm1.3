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
    public class ParticipantsDao : BaseDao
    {
        public List<Participants> GetAllParticipants(int activityID)
        {
            string query = $"select firstName, studentID, activityID FROM [StudentActivity] " +
                $"join Person on studentID=personID WHERE activityID ={activityID}";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<Participants> ReadTables(DataTable dataTable)
        {
            List<Participants> participantsList = new List<Participants>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participants participant = new Participants()
                {
                    ParticipantName = (string)(dr["firstName"].ToString()),
                    StudentID = (int)dr["studentID"],
                    ActivityID = (int)dr["activityID"],
                };
                participantsList.Add(participant);
            }
            return participantsList;
        }

        public void AddParticipant(Participants participants)
        {
            string query = $"INSERT INTO [StudentActivity] (studentID, activityID) VALUES ({participants.StudentID},{participants.ActivityID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

        }
        public void RemoveParticipant(Participants participants)
        {
            string query = $"DELETE FROM [StudentActivity] WHERE studentID = {participants.StudentID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

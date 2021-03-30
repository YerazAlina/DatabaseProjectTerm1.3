using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ParticipantsService
    {
        ParticipantsDao participantsdb;

        public ParticipantsService()
        {
            participantsdb = new ParticipantsDao();
        }

        public List<Participants> GetParticipant(int activityID)
        {
            List<Participants> participants = participantsdb.GetAllParticipants(activityID);

            return participants;
        }

        public void AddtoParticipant(Participants participants)
        {
            participantsdb.AddParticipant(participants);
        }

        public void RemoveParticipant(Participants participants)
        {
            participantsdb.RemoveParticipant(participants);
        }

    }
}

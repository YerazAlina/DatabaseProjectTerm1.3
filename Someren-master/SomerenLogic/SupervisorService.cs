using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class SupervisorService
    {
        SupervisorDao supervisordb;

        public SupervisorService()
        {
            supervisordb = new SupervisorDao();
        }

        public List<Supervisor> Getsupervisorss(int activityID)
        {
            List<Supervisor> supervisors = supervisordb.GetAllSupervisor(activityID);

            return supervisors;
        }

        public void AddDataToSupervisors(Supervisor supervisor)
        {
            supervisordb.AddSupervisor(supervisor);
        }

        public void RemoveDataFromSupervisor(Supervisor supervisor)
        {
            supervisordb.Removesupervisor(supervisor);
        }
    }
}

using System;
using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;


namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activities = activitydb.GetAllActivities();

            return activities;
        }

        public void AddDataToActivities(Activity activity)
        {
            activitydb.AddActivity(activity);
        }

        public void UpdateDataFromActivities(Activity activity)
        {
            activitydb.UpdateActivity(activity);
        }

        public void RemoveDataFromActivities(Activity activity)
        {
            activitydb.RemoveActivity(activity);
        }
    }
}

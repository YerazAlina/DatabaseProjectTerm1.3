using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        //public DateTime startDate;
        //public DateTime endDate;

        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }

        private void ShowPanel(string panelName)
        {
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlCashRegister.Hide();
            pnlStudents.Hide();
            pnlRevenueReport.Hide();
            pnlActivities.Hide();
                
            //try catch 
            if (panelName == "Dashboard")
            {
                ShowPanelDashboard();
            }
            else if (panelName == "Students")
            {
                ShowPanelStudents();
            }
            else if (panelName == "Rooms")
            {
                ShowPanelRooms();
            }
            else if (panelName == "Teachers")
            {
                ShowPanelTeachers();
            }
            else if (panelName == "Cash Register")
            {
                ShowPanelCashRegisterStudents();
                ShowPanelCashRegisterDrinks();
            }
            else if (panelName == "Drinks")
            {
                ShowPanelDrinks();
            }
            else if (panelName == "Revenue Report")
            {
                ShowPanelRevenueReport();
            }
            else if (panelName == "Activities")
            {
                ShowPanelActivities();
            }
        }
        
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowPanel("Dashboard");
        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Teachers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Rooms");
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Drinks");
        }

        private void toolStripMenuItemCashRegister_Click(object sender, EventArgs e)
        {
            ShowPanel("Cash Register");
        }

        private void toolStripMenuItemRevenueReport_Click(object sender, EventArgs e)
        {
            ShowPanel("Revenue Report");
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Activities");
        }

        /// <summary>
        /// dashboard
        /// </summary>
        private void ShowPanelDashboard()
        {
            //show panels 
            pnlDashboard.Show();
            imgDashboard.Show();
        }

        /// <summary>
        /// students
        /// </summary>
        private void ShowPanelStudents()
        {
            //show students
            pnlStudents.Show();

            try
            {
                StudentService studService = new StudentService(); ;
                List<Student> studentsList = studService.GetStudents(); ;

                listViewStudents.Items.Clear();

                foreach (Student student in studentsList)
                {
                    ListViewItem li = new ListViewItem(student.Number.ToString());
                    li.SubItems.Add(student.FirstName);
                    li.SubItems.Add(student.LastName);
                    
                    listViewStudents.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Something went wrong while loading students" + e.Message, EventLogEntryType.Information, 101, 1);
                }

                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowPanelTeachers()
        {
            //show 
            pnlTeachers.Show();

            try
            {
                TeacherService teacherService = new TeacherService(); 
                List<Teacher> teachersList = teacherService.GetTeachers(); 

                listViewTeachers.Items.Clear();

                foreach (Teacher teacher in teachersList)
                {
                    ListViewItem li = new ListViewItem(teacher.Number.ToString());
                    li.SubItems.Add(teacher.FirstName);
                    li.SubItems.Add(teacher.LastName);
                    li.SubItems.Add(teacher.Supervisor.ToString());

                    listViewTeachers.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Something went wrong while loading teachers" + e.Message, EventLogEntryType.Information, 101, 1);
                }

                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }

        /// <summary>
        /// rooms
        /// </summary>
        private void ShowPanelRooms()
        {
            //show
            pnlRooms.Show();

            try
            {
                RoomService roomService = new RoomService(); 
                List<Room> roomsList = roomService.GetRooms(); 

                listViewRooms.Items.Clear();

                foreach (Room room in roomsList)
                {
                    ListViewItem li = new ListViewItem(room.Number.ToString());
                    li.SubItems.Add(room.Capacity.ToString());
                    li.SubItems.Add(room.Type);

                    listViewRooms.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Something went wrong while loading rooms" + e.Message, EventLogEntryType.Information, 101, 1);
                }
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        /// <summary>
        /// cash register
        /// </summary>
        private void ShowPanelCashRegisterStudents()
        {
            //show
            pnlCashRegister.Show();

            //students
            try
            {
                StudentService studService = new StudentService(); 
                List<Student> studentsList = studService.GetStudents(); 

                listViewStudentsCashReg.Items.Clear();

                foreach (Student student in studentsList)
                {
                    ListViewItem li = new ListViewItem(student.Number.ToString());
                    li.SubItems.Add(student.FirstName);
                    li.SubItems.Add(student.LastName);
                    //li.Tag = student;
                    //student = listViewStudentsCashReg.SelectedItems[0];

                    listViewStudentsCashReg.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Something went wrong while loading Students" + e.Message, EventLogEntryType.Information, 101, 1);
                }
                MessageBox.Show("Something went wrong while loading the Students: " + e.Message);
            }  
        }

        private void ShowPanelCashRegisterDrinks()
        {
            //drinks
            try
            {
                DrinkService drinkService = new DrinkService();
                List<Drink> drinksList = drinkService.GetDrinks();

                listViewDrinksCashReg.Items.Clear();

                foreach (Drink drink in drinksList)
                {
                    ListViewItem li = new ListViewItem(drink.DrinkID.ToString());
                    li.SubItems.Add(drink.DrinkName);
                    li.SubItems.Add(drink.Price.ToString());
                    li.SubItems.Add(drink.IsAlcoholic);

                    listViewDrinksCashReg.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Something went wrong while loading Drinks" + e.Message, EventLogEntryType.Information, 101, 1);
                }
                MessageBox.Show("Something went wrong while loading the Drinks: " + e.Message);
            }
        }

        /// <summary>
        /// drinks
        /// </summary>
        private void ShowPanelDrinks()
        {
            //show
            pnlDrinks.Show();

            try
            {
                DrinkService drinkService = new DrinkService(); 
                List<Drink> drinksList = drinkService.GetDrinks(); 

                listViewDrinks.Items.Clear();

                foreach (Drink drink in drinksList)
                {
                    ListViewItem li = new ListViewItem(drink.DrinkID.ToString());
                    li.SubItems.Add(drink.DrinkName);
                    li.SubItems.Add(drink.Price.ToString());
                    li.SubItems.Add(drink.Stock.ToString());
                    li.SubItems.Add(drink.IsAlcoholic);

                    if (drink.Stock < 10)
                    {
                        li.SubItems.Add("Stock nearly depleted");
                    }
                    else
                    {
                        li.SubItems.Add("Stock sufficient");
                    }

                    listViewDrinks.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Something went wrong while loading Drinks" + e.Message, EventLogEntryType.Information, 101, 1);
                }
                MessageBox.Show("Something went wrong while loading the Drinks: " + e.Message);
            }
        }

        private void bttnAddDrink_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();

            drink.DrinkID = int.Parse(txtBoxDrinkId.Text);
            drink.DrinkName = txtBoxDrinkName.Text;
            drink.Price = decimal.Parse(txtBoxPrice.Text);
            drink.Stock = int.Parse(txtBoxStock.Text);
            drink.IsAlcoholic = txtBoxDrinkName.Text;

            DrinkService drinkService = new DrinkService();
            drinkService.AddDataToDrinks(drink);

            listViewDrinks.Items.Clear();

            MessageBox.Show("record added!");
            ShowPanel("Drinks");
        }

        private void bttnRemoveDrink_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();

            drink.DrinkID = int.Parse(txtBoxDrinkId.Text);

            DrinkService drinkService = new DrinkService();
            drinkService.RemoveDataFromDrinks(drink);

            listViewDrinks.Items.Clear();

            MessageBox.Show("record removed!");
            ShowPanel("Drinks");
        }

        private void bttnUpdateDrinks_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();

            drink.DrinkID = int.Parse(txtBoxDrinkId.Text);
            drink.DrinkName = txtBoxDrinkName.Text;
            drink.Price = decimal.Parse(txtBoxPrice.Text);
            drink.Stock = int.Parse(txtBoxStock.Text);
            drink.IsAlcoholic = txtBoxAlcohol.Text;

            DrinkService drinkService = new DrinkService();
            drinkService.UpdateDataFromDrinks(drink);

            listViewDrinks.Items.Clear();

            MessageBox.Show("record updated!");
            ShowPanel("Drinks");
        }

        private void bttnCheckOut_Click(object sender, EventArgs e)
        { 
            if (listViewDrinksCashReg.SelectedItems.Count > 0 && listViewStudentsCashReg.SelectedItems.Count > 0)
            {
                ListViewItem li = listViewStudentsCashReg.SelectedItems[0];
                
                Student s = new Student();
                s.Number = int.Parse(li.SubItems[0].Text);
                s.FirstName = li.SubItems[1].Text;
                s.LastName = li.SubItems[2].Text;

                ListViewItem li2 = listViewDrinksCashReg.SelectedItems[0];
                
                Drink d = new Drink();
                d.DrinkID = int.Parse(li2.SubItems[0].Text);
                d.DrinkName = li2.SubItems[1].Text;
                d.Price = decimal.Parse(li2.SubItems[2].Text);

                OrderService orderService = new OrderService(); ;

                DateTime date = DateTime.Now;
                orderService.AddDataToOrder(d, s, date);

                MessageBox.Show("Order has been made!");
                lbl_CheckOut.Text = s.ToString() + "\n" + d.ToString(); 
            }
        }

        private void listViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem li = listViewDrinks.SelectedItems[0];
                txtBoxDrinkId.Text = li.SubItems[0].Text;
                txtBoxDrinkName.Text = li.SubItems[1].Text;
                txtBoxPrice.Text = li.SubItems[2].Text;
                txtBoxStock.Text = li.SubItems[3].Text;
                txtBoxAlcohol.Text = li.SubItems[4].Text;
            }
        }

        /// <summary>
        /// revenue report
        /// </summary>
        private void ShowPanelRevenueReport()
        {
            pnlRevenueReport.Show();
        }

        private void monthCalendarRevenueReport_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                
                decimal sum = 0;
                DateTime startDate = monthCalendarRevenueReport.SelectionRange.Start;
                DateTime endDate = monthCalendarRevenueReport.SelectionRange.End;

                DateTime today = DateTime.Today.Date;

                if (startDate > today)
                {
                    monthCalendarRevenueReport.SelectionStart = today;
                    throw new Exception("Invalid start date!");
                    //MessageBox.Show("Invalid start date!");
                }

                else if (endDate > today)
                {
                    monthCalendarRevenueReport.SelectionEnd = today;
                    throw new Exception("Invalid end date!");
                    //MessageBox.Show("Invalid end date!");
                }

                else if (startDate > endDate)
                {
                    monthCalendarRevenueReport.SelectionRange.Start = monthCalendarRevenueReport.SelectionRange.End;
                    throw new Exception("Start date is after end date!");
                    //MessageBox.Show("Start date is after end date");
                }

                else if (startDate == endDate)
                {
                    endDate = endDate.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                }

                OrderService orderService = new OrderService();
                List<Order> orders = orderService.GetOrders(startDate, endDate);

                listViewRevRep.Items.Clear();

                List<int> customers = new List<int>();

                foreach (Order o in orders)
                {
                    sum += o.Price;

                    if (!customers.Contains(o.StudentID))
                    {
                        customers.Add(o.StudentID);
                    }
                }

                ListViewItem li = new ListViewItem(orders.Count.ToString());
                li.SubItems.Add(sum.ToString());
                li.SubItems.Add(customers.Count().ToString()); //(sum.ToString()); 

                listViewRevRep.Items.Add(li);
            }
            catch (Exception ex)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Something went wrong while ordering the drink" + ex.Message, EventLogEntryType.Information, 101, 1);
                }
                MessageBox.Show("Something went wrong while ordering the drink: " + ex.Message);
            }
        }

        /// <summary>
        /// Activites
        /// </summary>
        private void ShowPanelActivities()
        {
            //show
            pnlActivities.Show();

            try
            {
                ActivityService activityService = new ActivityService();
                List<Activity> activitiesList = activityService.GetActivities();

                listViewActivities.Items.Clear();

                foreach (Activity activity in activitiesList)
                {
                    ListViewItem li = new ListViewItem(activity.ActivityId.ToString());
                    li.SubItems.Add(activity.Description);
                    li.SubItems.Add(activity.StartTime.ToString());
                    li.SubItems.Add(activity.EndDate.ToString());

                    listViewActivities.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Something went wrong while loading Activities" + e.Message, EventLogEntryType.Information, 101, 1);
                }
                MessageBox.Show("Something went wrong while loading the Activities: " + e.Message);
            }
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem li = listViewActivities.SelectedItems[0];
                txtBoxActivityId.Text = li.SubItems[0].Text;
                txtBoxActivityDescription.Text = li.SubItems[1].Text;
                txtBoxStartTimeActivity.Text = li.SubItems[2].Text;
                txtBoxEndTimeActivity.Text = li.SubItems[3].Text;
            }
        }

        private void bttnAddActivity_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();

            activity.ActivityId = int.Parse(txtBoxActivityId.Text);
            activity.Description = txtBoxActivityDescription.Text;
            activity.StartTime = DateTime.Parse(txtBoxStartTimeActivity.Text);
            activity.EndDate = DateTime.Parse(txtBoxEndTimeActivity.Text);

            ActivityService activityService = new ActivityService();
            activityService.AddDataToActivities(activity);

            listViewActivities.Items.Clear();

            MessageBox.Show("Activity added!");
            ShowPanel("Activity");
        }

        private void bttnUpdateActivity_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();

            activity.ActivityId = int.Parse(txtBoxActivityId.Text);
            activity.Description = txtBoxActivityDescription.Text;
            activity.StartTime = DateTime.Parse(txtBoxStartTimeActivity.Text);
            activity.EndDate = DateTime.Parse(txtBoxEndTimeActivity.Text);

            ActivityService activityService = new ActivityService();
            activityService.UpdateDataFromActivities(activity);

            listViewActivities.Items.Clear();

            MessageBox.Show("Activity added!");
            ShowPanel("Activity");
        }

        private void bttnDeleteActivity_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();

            activity.ActivityId = int.Parse(txtBoxActivityId.Text);

            ActivityService activityService = new ActivityService();
            activityService.UpdateDataFromActivities(activity);

            listViewActivities.Items.Clear();

            MessageBox.Show("Activity added!");
            ShowPanel("Activity");
        }
    }
}
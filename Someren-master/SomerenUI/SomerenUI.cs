using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
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
                ShowPanelCashRegister();
            }
            else if (panelName == "Drinks")
            {
                ShowPanelDrinks();
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

        private void label1_Click(object sender, EventArgs e)
        {
            //remove
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

        private void label1_Click_1(object sender, EventArgs e)
        {
            //remove
        }

        private void lbl_Students_Click(object sender, EventArgs e)
        {
            //remove
        }

        private void CashRegisterStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Cash Register");
        }

        private void BarServicetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Bar Service");
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("Drinks");
        }

        private void ShowPanelDashboard()
        {
            //hide other panels 
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlTeachers.Hide();
            pnlCashRegister.Hide();
            pnlDrinks.Hide();

            //show panels 
            pnlDashboard.Show();
            imgDashboard.Show();
        }

        private void ShowPanelStudents()
        {
            //hide all other panels
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlCashRegister.Hide();

            //show students
            pnlStudents.Show();

            try
            {
                StudentService studService = new StudentService(); ;
                List<Student> studentList = studService.GetStudents(); ;

                listViewStudents.Items.Clear();

                foreach (Student s in studentList)
                {
                    ListViewItem li1 = new ListViewItem(s.Number.ToString());
                    li1.SubItems.Add(s.FirstName);
                    li1.SubItems.Add(s.LastName);

                    listViewStudents.Items.Add(li1);
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
            //hide all other panels
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlCashRegister.Hide();

            //show 
            pnlTeachers.Show();

            try
            {
                TeacherService teacherService = new TeacherService(); ;
                List<Teacher> teacherList = teacherService.GetTeachers(); ;

                listViewTeachers.Items.Clear();

                foreach (Teacher t in teacherList)
                {
                    ListViewItem li1 = new ListViewItem(t.Number.ToString());
                    li1.SubItems.Add(t.FirstName);
                    li1.SubItems.Add(t.LastName);
                    li1.SubItems.Add(t.Supervisor.ToString());

                    listViewTeachers.Items.Add(li1);
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

        private void ShowPanelRooms()
        {
            // hide all other panels
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlDrinks.Hide();
            pnlCashRegister.Hide();

            //show
            pnlRooms.Show();

            try
            {
                RoomService roomService = new RoomService(); ;
                List<Room> roomList = roomService.GetRooms(); ;

                listViewRooms.Items.Clear();

                foreach (Room r in roomList)
                {
                    ListViewItem li1 = new ListViewItem(r.Number.ToString());
                    li1.SubItems.Add(r.Capacity.ToString());
                    li1.SubItems.Add(r.Type);

                    listViewRooms.Items.Add(li1);
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

        private void ShowPanelCashRegister()
        {
            // hide all other panels
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlTeachers.Hide();

            //show
            pnlCashRegister.Show();

            //students
            try
            {
                StudentService studService = new StudentService(); ;
                List<Student> studentList = studService.GetStudents(); ;

                listViewStudentsCashReg.Items.Clear();

                foreach (Student s in studentList)
                {
                    ListViewItem li1 = new ListViewItem(s.Number.ToString());
                    li1.SubItems.Add(s.FirstName);
                    li1.SubItems.Add(s.LastName);
                    listViewStudentsCashReg.Items.Add(li1);
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

            //drinks
            try
            {
                DrinkService drinkService = new DrinkService(); ;
                List<Drink> drinkList = drinkService.GetDrinks(); ;

                listViewDrinksCashReg.Items.Clear();

                foreach (Drink d in drinkList)
                {
                    ListViewItem li2 = new ListViewItem(d.DrinkID.ToString());
                    li2.SubItems.Add(d.DrinkName);
                    li2.SubItems.Add(d.Price.ToString());
                    li2.SubItems.Add(d.IsAlcoholic);
                    listViewDrinksCashReg.Items.Add(li2);
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

        private void ShowPanelDrinks()
        {
            // hide all other panels
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlCashRegister.Hide();

            //show
            pnlDrinks.Show();

            try
            {
                DrinkService drinkService2 = new DrinkService(); ;
                List<Drink> drinkList = drinkService2.GetDrinks(); ;

                listViewDrinks.Items.Clear();

                foreach (Drink d in drinkList)
                {
                    ListViewItem li2 = new ListViewItem(d.DrinkID.ToString());
                    li2.SubItems.Add(d.DrinkName);
                    li2.SubItems.Add(d.Price.ToString());
                    li2.SubItems.Add(d.IsAlcoholic);

                    listViewDrinks.Items.Add(li2);
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
          
            MessageBox.Show("record added!");

            DrinkService drinkService = new DrinkService();

            drinkService.AddDataToDrinks(drink);
            listViewDrinks.Items.Clear();

            ShowPanel("Drinks");
        }

        private void bttnRemoveDrink_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();

            drink.DrinkID = int.Parse(txtBoxDrinkId.Text);
            
            MessageBox.Show("record removed!");

            DrinkService drinkService = new DrinkService();

            drinkService.RemoveDataFromDrinks(drink);
            listViewDrinks.Items.Clear();

            ShowPanel("Drinks");
        }

        private void bttnUpdateDrinks_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();

            drink.DrinkID = int.Parse(txtBoxDrinkId.Text);
            drink.DrinkName = txtBoxDrinkName.Text;
            drink.Price = decimal.Parse(txtBoxPrice.Text);

            MessageBox.Show("record updated!");

            DrinkService drinkService = new DrinkService();

            drinkService.RemoveDataFromDrinks(drink);
            listViewDrinks.Items.Clear();

            ShowPanel("Drinks");
        }
    }
}
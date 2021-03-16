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
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlTeachers.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlCashRegister.Hide();
            pnlStudents.Hide();

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
            //show panels 
            pnlDashboard.Show();
            imgDashboard.Show();
        }

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
                    li.Tag = student;

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
                    li.Tag = drink;

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

        private void ShowPanelDrinks()
        {
            //test
            //pnlDrinks.BringToFront();

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
                    li.SubItems.Add("test");

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
            drink.IsAlcoholic = txtBoxDrinkName.Text;

            DrinkService drinkService = new DrinkService();
            drinkService.UpdateDataFromDrinks(drink);

            listViewDrinks.Items.Clear();

            MessageBox.Show("record updated!");
            ShowPanel("Drinks");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetOrdersByDate(DateTime startDate, DateTime endDate)
        {
            string query = $"SELECT orderID, personID, [date], price, Drinks.drinkID FROM [Order] JOIN Drinks ON [Order].drinkID = Drinks.drinkID WHERE [date] BETWEEN '{startDate.ToString("yyyy-MM-dd")}' AND '{endDate.ToString("yyyy-MM-dd")}';";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddOrder(Drink d, Student s, DateTime date)
        {
            string query = $"INSERT INTO [Order] (drinkID, personID, date) Values ({d.DrinkID}, {s.Number}, '{date.Year}-{date.Month}-{date.Day} {date.Hour}:{date.Minute}:{date.Second}');";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);

        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    DrinkID = (int)dr["drinkID"],
                    OrderNr = (int)(dr["orderID"]),
                    StudentID = (int)(dr["personID"]),
                    Date = (DateTime)dr["date"],
                    Price = (decimal)dr["price"]

                };
                orders.Add(order);
            }

            return orders;
        }
    }
}

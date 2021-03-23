using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT drinkID, drinkName, price, stock, isAlcoholic FROM [Drinks]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkID = (int)dr["drinkID"],
                    DrinkName = (string)(dr["drinkName"].ToString()),
                    Price = (decimal)(dr["price"]),
                    Stock = (int)dr["stock"],
                    IsAlcoholic = (string)dr["isAlcoholic"].ToString(),

                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public void AddDrink(Drink d)
        {
            string price = string.Format(d.Price.ToString()).Replace(',', '.');
            string query = $"INSERT INTO [Drinks] (drinkID, drinkName, price, stock, isAlcoholic) Values ( {d.DrinkID},'{d.DrinkName}', {price}, {d.Stock}, '{d.IsAlcoholic}') ";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            Console.WriteLine(query);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDrink(Drink d)
        {
            string price = string.Format(d.Price.ToString()).Replace(',', '.');
            string query = $"UPDATE [Drinks] SET drinkName='{d.DrinkName}', price='{price}', stock={d.Stock}, isAlcoholic='{d.IsAlcoholic}' WHERE drinkID='{d.DrinkID}' ";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveDrink(Drink d)
        {
            string query = $"DELETE FROM [Drinks] WHERE drinkID='{d.DrinkID}' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);

        }
    }
}

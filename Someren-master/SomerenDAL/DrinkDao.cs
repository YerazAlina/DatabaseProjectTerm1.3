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
                    Stock = (int)(dr["stock"]),
                    IsAlcoholic = (string)(dr["isAlcoholic"].ToString())
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public void AddDrink(Drink drink)
        {
            string queryDrink = $"INSERT INTO [Drinks] (drinkID, drinkName, price, stock, isAlcoholic) Values ({drink.DrinkID},'{drink.DrinkName}', {drink.Price}, '{drink.Stock}', '{drink.IsAlcoholic}') ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(queryDrink, sqlParameters);
        }

        public void UpdateDrink(Drink drink)
        {
            string queryDrink = $"UPDATE [Drinks] SET drinkName ='{drink.DrinkName}' , price ='{drink.Price}' WHERE drinkID ='{drink.DrinkID}' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(queryDrink, sqlParameters);
        }

        public void RemoveDrink(Drink drink)
        {
            string queryDrink = $"DELETE FROM [Drinks] WHERE drinkID ='{drink.DrinkID}' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(queryDrink, sqlParameters);
        }
    }
}

using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();

            return drinks;
        }

        public void AddDataToDrinks(Drink drink)
        {
            drinkdb.AddDrink(drink);
        }

        public void UpdateDataFromDrinks(Drink drink)
        {
            drinkdb.UpdateDrink(drink);
        }

        public void RemoveDataFromDrinks(Drink drink)
        {
            drinkdb.RemoveDrink(drink);
        }
    }
}

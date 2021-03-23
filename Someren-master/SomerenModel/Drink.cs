namespace SomerenModel
{
    public class Drink
    {
        public int DrinkID { get; set; }
        public string DrinkName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string IsAlcoholic { get; set; }


        public override string ToString()
        {
            return $"Drink: {DrinkName}" + "\n" + $"Price: €{Price}";
        }
    }
}


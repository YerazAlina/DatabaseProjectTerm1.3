using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order 
    {
        public int OrderNr { get; set; }

        public int DrinkID { get; set; }

        public int StudentID { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }
    }
}

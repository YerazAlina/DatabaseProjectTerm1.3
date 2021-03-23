using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class OrderService
    {
        OrderDao orderdb;

        public OrderService()
        {
            orderdb = new OrderDao();
        }

        public List<Order> GetOrders(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = orderdb.GetOrdersByDate(startDate, endDate);
            return orders;
        }

        public void AddDataToOrder(Drink drink, Student student, DateTime date)
        {
            orderdb.AddOrder(drink, student, date);
        }
    }
}

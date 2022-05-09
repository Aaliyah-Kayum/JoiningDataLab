using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JoiningDataLab
{
    public class Program
    { 
        public static void Main()
        {
            List<Order> ordersPlaced = new List<Order>();

            Order one = new Order("Acme Hardware", "Mouse", 25, 3, 75);
            ordersPlaced.Add(one);
            Order two = new Order("Acme Hardware", "Keyboard", 45, 2, 90);
            ordersPlaced.Add(two);
            Order three = new Order("Falls Realty", "Macbook", 800, 2, 1600);
            ordersPlaced.Add(@three);
            Order four = new Order("Julie's Morning Diner", "iPad", 525, 1, 525);
            ordersPlaced.Add(@four);
            Order five = new Order("Julie's Morning Diner", "Credit Card Reader", 45, 1, 45);
            ordersPlaced.Add(five);
            ordersPlaced.ToArray();

            bool runAgain = true;
            while (runAgain)
            {
                foreach (Order order in ordersPlaced)
                {
                    //order.//(ordersPlaced);
                    order.Header(order);
                }
                runAgain = false;
            }

        }
    }
}

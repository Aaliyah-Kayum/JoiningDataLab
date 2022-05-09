using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningDataLab
{
    class Order
    {
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
        public Decimal Total { get; set; }


        public Order(string customerName, string item, decimal price, int quantity, decimal total)
        {
            this.CustomerName = customerName;
            this.Item = item;
            this.Price = price;
            this.Quantity = quantity;
            this.Total = total;
        }
        public void orderTotal(int Quantity, decimal total)
        {
            total = 2 * Quantity;
        }
        public void Header(Order selectOrder)
        {
            Console.WriteLine($"{selectOrder}");
            Console.WriteLine();
            Console.WriteLine("Customer\tItem\tPrice\tQuantity\tTotal");
            Console.WriteLine($"{selectOrder.CustomerName}\t{selectOrder.Item}\t{selectOrder.Price}\t{selectOrder.Quantity}\t{selectOrder.Total}");
            Console.WriteLine();
        }

    }
}

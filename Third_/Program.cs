using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_.Model;


namespace Third_
{
    class Program
    {
        static void Main(string[] args)
        {

            Customers customers1 = new Customers { customer_id = 1, customer_name = "Vlad", Id = 1 };
            Customers customers = new Customers() { customer_id = 2, customer_name = "Vova", Id = 2 };
            Orders orders1 = new Orders() { customer_id = 1, order_id = "23", amount = 90, Id = 1 };
            Orders orders2 = new Orders() { customer_id = 2, order_id = "21", amount = 100, Id = 1 };
            Orders orders3 = new Orders() { customer_id = 1, order_id = "29", amount = 150, Id = 1 };
            Console.WriteLine(customers1.customer_name +"  "+ customers1.customer_id + "\n" +orders1.customer_id + "  " + orders1.amount + "  " + orders1.order_id);
            Console.WriteLine(customers1.customer_name + "  " + customers1.customer_id + "\n" + orders3.customer_id + "  " + orders3.amount + "  " + orders3.order_id);
            Console.WriteLine(customers.customer_name + "  " + customers.customer_id + "\n" + orders2.customer_id + "  " + orders2.amount + "  " + orders2.order_id);
            Console.ReadLine();
        }
    }
}
//if (customers1.customer_id == orders1.customer_id)
//{
//    Console.WriteLine($"{customers1.customer_name} " + "   " + customers1.customer_name + "   " + orders1.order_id + "   " + orders1.amount);
//}
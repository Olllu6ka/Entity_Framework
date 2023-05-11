using _Six.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_.Model;

namespace _Six
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customers1 = new Customers { customer_id = 1, customer_name = "Oleg", Id = 11 };
            Customers customers = new Customers() { customer_id = 2, customer_name = "Alex", Id = 22 };
            Model1Container container = new Model1Container();
            Orders orders1 = new Orders() { customer_id = 1, order_id = "245", amount = 910, Id = 11 };
            Orders orders2 = new Orders() { customer_id = 2, order_id = "2166", amount = 1030, Id = 21 };
            Orders orders3 = new Orders() { customer_id = 1, order_id = "2966", amount = 1550, Id = 14 };
            Console.WriteLine(customers1.customer_name + "  " + customers1.customer_id + "\n" + orders1.customer_id + "  " + orders1.amount + "  " + orders1.order_id);
            Console.WriteLine(customers1.customer_name + "  " + customers1.customer_id + "\n" + orders3.customer_id + "  " + orders3.amount + "  " + orders3.order_id);
            Console.WriteLine(customers.customer_name + "  " + customers.customer_id + "\n" + orders2.customer_id + "  " + orders2.amount + "  " + orders2.order_id);
            var id = customers1.customer_name.Select(i => i != 'V'); 
            Console.WriteLine(id.Last() + " - cработала селект");
            Console.ReadLine();
        }
    }
}

using _Four.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Four
{
    class Program
    {
        static void Main(string[] args)
        {
            PesinalInfo info1 = new PesinalInfo(){customer_id = 20,amount = 100,order_id = 125};
            PesinalInfo info2 = new PesinalInfo() { customer_id = 21, amount = 98, order_id = 126 };
            PesinalInfo info3 = new PesinalInfo() { customer_id = 21, amount = 15, order_id = 217 };
            Items items1 = new Items() { items_id = 200, items_name = "Хочу заказать сегодня" };
            Items items2 = new Items() { items_id = 201, items_name = "Завтра" };
            Items_Order items_order1 = new Items_Order() { items_id = 200, order_id = 125 };
            Items_Order items_order2 = new Items_Order() { items_id = 200, order_id = 217 };
            Model1 model1 = new Model1();
            foreach (var info in model1.MyEntities)
            {
                Console.WriteLine($"{info.order_id} - {info.customer_id} - {info.amount}");
                foreach (var items_order in model1.Items_Orders)
                {
                    if (info.order_id == items_order.order_id)
                    {
                        Console.WriteLine($"{items_order.order_id} - {items_order.items_id}");
                        foreach (var items in model1.Items)
                        {
                            Console.WriteLine($"{items.items_id} - {items.items_name}");
                        }
                    }
                }
            }
            Console.ReadKey();
        }

    }
}

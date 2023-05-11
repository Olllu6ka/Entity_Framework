using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace _Four.Model
{
     public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }
         public virtual DbSet<PesinalInfo> MyEntities { get; set; }
         public virtual DbSet<Items> Items { get; set; }
         public virtual DbSet<Items_Order> Items_Orders { get; set; }
    }

    public class PesinalInfo
    {
        [Key]
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public int amount { get; set; }
    }
    public class Items {
        [Key]
        public int items_id { get; set; }
        public string items_name{ get; set; }
    }
    public class Items_Order {
        [Key]
        public int order_id { get; set; }
        public int items_id { get; set; }
    }


}
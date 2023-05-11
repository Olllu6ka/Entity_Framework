using System;
using System.Data.Entity;
using System.Linq;

namespace _Second.Model
{
    public class Model1 : DbContext
    {
        
        public Model1()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Users> MyEntities { get; set; }
    }
    
    public class Users
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyHomeApi
{
    public class MyContext : DbContext
    {
        public MyContext() 
            :base("MyHomeEntity")
            {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }
        public DbSet<Property> Properties { get; set; }
    }
}
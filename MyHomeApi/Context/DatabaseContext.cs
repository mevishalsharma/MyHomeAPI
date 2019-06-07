using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyHomeApi.Context
{
    public class MyHomeDBContext : DbContext
    {
        public MyHomeDBContext()  : base("MyHomeEntity")
        {
            Database.SetInitializer<MyHomeDBContext>(new DatabaseInitializerEF<MyHomeDBContext>());
        }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
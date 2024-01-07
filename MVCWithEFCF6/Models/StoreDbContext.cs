using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWithEFCF6.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext() : base("ConStr")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<StoreDbContext>());    
        }
        public DbSet<Product> Products { get; set;}
        public DbSet<Customer> Customers { get; set;}

    }
}
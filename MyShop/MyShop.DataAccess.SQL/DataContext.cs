using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext  // db context is a class that exists in the entity framework.
    {
        public DataContext() : base("DefaultConnection") // We're passing our connection string.
        {

        }
        // DbSets help specify which classes you do want to store in the data base.
        public DbSet<Product> Products { get; set; }    
        public DbSet<ProductCategory> ProductsCategories { get; set; }
    }
}

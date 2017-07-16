using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.Data.Entity;
using ResourcesFiles.Models;

namespace ResourcesFiles.DataDbContext
{
    public class MyProductsDbContext : DbContext
    {

        public MyProductsDbContext(): base(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True;Pooling=False")
        {
            
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
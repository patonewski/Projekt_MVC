using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC
{
    public class Product
    {
        public int Id { set; get; }
        public string ProductName { set; get; }
        public string Description { set; get; }
        public float Price { set; get; }
    }


    public class ProductDBContext
    {
        public DbSet<Product> Products { get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string ProductName { set; get; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public float Price { set; get; }
        public string Description { set; get; }
        

    }


    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
    }
    public class BasketDBContext : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }
    }
}

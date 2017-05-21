using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC
{
    public class Basket
    {
        
        public int Id;
        ArrayList Products = new ArrayList();

    }

    public class BasketDBContext
    {
        public DbSet<Basket> Baskets { get; set; }
    }
}
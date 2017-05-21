using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public List<Product> Lista = new List<Product>();
    }

}
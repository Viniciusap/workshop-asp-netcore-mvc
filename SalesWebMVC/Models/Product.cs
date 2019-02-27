using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, double price, string type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
    }
}

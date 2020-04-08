using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int BarCode { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name = "No name",
                   int barcode = 0,
                   double price = 0.0,
                   int quantity = 0)
        {
            Name = name;
            BarCode = barcode;
            Price = price;
            Quantity = quantity;
        }
    }
}

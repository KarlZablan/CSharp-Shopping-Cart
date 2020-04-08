using ShoppingCart.Business.Models;
using ShoppingCart.Business.Repositories.Interfaces;
using ShoppingCart.Data.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        private readonly string _path = string.Empty; //ConfigurationManager.AppSettings["GroceryDatabase"]
        public ProductRepository()
        {
            foreach (string line in CsvIO.ReadCSVString(_path).Skip(1))
            {
                string[] values = line.Split(',');
                Items.Add(new Product(values[0], Convert.ToInt32(values[1]), Convert.ToDouble(values[2])));
            };
        }
    }
}

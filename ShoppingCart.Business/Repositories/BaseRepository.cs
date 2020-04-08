using ShoppingCart.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Repositories
{
    internal abstract class BaseRepository
    {
        protected List<Product> Items = new List<Product>();

        public List<Product> GetAll()
        {
            return Items;
        }
        public Product GetByBarcode(int barcode)
        {
            foreach (Product item in Items)
            {
                if (item.BarCode == barcode)
                {
                    return item;
                }
            }

            return null;
        }

        public Product GetByName(string name)
        {
            foreach (Product item in Items)
            {
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return item;
            }

            return null;
        }
    }
}

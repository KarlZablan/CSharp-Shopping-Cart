using ShoppingCart.Business.Managers.Interfaces;
using ShoppingCart.Business.Models;
using ShoppingCart.Business.Repositories;
using ShoppingCart.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Managers
{
    public abstract class BaseManager 
    {
        public abstract IRepository Repository { get; }

        public List<Product> GetAll()
        {
            return Repository.GetAll();
        }

        public Product GetByBarcode(int barcode)
        {
            return Repository.GetByBarcode(barcode);
        }

        public Product GetByName(string name)
        {
            return Repository.GetByName(name);
        }
    }
}

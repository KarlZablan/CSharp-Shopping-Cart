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
    public class ProductManager : BaseManager
    {
        public override IRepository Repository => new ProductRepository();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Business.Models;

namespace ShoppingCart.Business.Repositories.Interfaces
{
    public interface  IRepository
    {
        Product GetByName(string name);
        Product GetByBarcode(int barcode);
        List<Product> GetAll();
    }
}

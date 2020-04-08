using ShoppingCart.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Managers.Interfaces
{
    public interface IManager
    {
        List<Product> GetAll();
        Product GetByBarcode(int barcode);
        Product GetByName(string name);
    }
}

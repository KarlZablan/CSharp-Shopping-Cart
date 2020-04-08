using ShoppingCart.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Managers.Interfaces
{
    public interface ICartManager : IManager
    {
        bool AddItem(Product item);
        bool ChangeQuantity(Product item, int quantity);
        double GetTotalPrice();

    }
}

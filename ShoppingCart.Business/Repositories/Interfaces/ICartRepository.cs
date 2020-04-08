using ShoppingCart.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Repositories.Interfaces
{
    public interface ICartRepository:IRepository
    {
        bool AddItem(Product item);
        bool ChangeQuantity(Product item, int quantity);
        double GetTotalPrice();
    }
}

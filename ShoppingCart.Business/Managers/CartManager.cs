using ShoppingCart.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Business.Repositories.Interfaces;
using ShoppingCart.Business.Repositories;
using ShoppingCart.Business.Managers.Interfaces;

namespace ShoppingCart.Business.Managers
{
    public class CartManager: BaseManager, ICartManager
    {
        public override IRepository Repository =>  new CartRepository();

        public bool AddItem(Product item)
        {
            return item != null? ((ICartRepository)Repository).AddItem(item) : false;
        }

        public bool ChangeQuantity(Product item, int quantity)
        {
            return item != null ?  ((ICartRepository)Repository).ChangeQuantity(item, quantity) : false;
        }

        public double GetTotalPrice()
        {
            return ((ICartRepository)Repository).GetTotalPrice();
        }

    }
}

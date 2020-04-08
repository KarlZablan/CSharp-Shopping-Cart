using ShoppingCart.Business.Models;
using ShoppingCart.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Repositories
{
    internal class CartRepository: BaseRepository, ICartRepository
    {
        public bool AddItem(Product item)
        {
            try
            {
                var cartItem = Items.FirstOrDefault(x => x.BarCode == item.BarCode);

                if (cartItem == null)
                {
                    Items.Add(new Product(item.Name, item.BarCode, item.Price, 1));
                }
                else
                {
                    cartItem.Quantity += 1;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ChangeQuantity(Product item, int quantity)
        {
            try
            {
                var cartItem = Items.FirstOrDefault(x =>x.BarCode == item.BarCode);

                if (quantity == 0)
                {
                    Items.Remove(cartItem);
                }
                else
                {
                    cartItem.Quantity = quantity;
                }

                return true;
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        public double GetTotalPrice()
        {
            return Items.Sum(x => x.Price * x.Quantity);
        }
    }
}

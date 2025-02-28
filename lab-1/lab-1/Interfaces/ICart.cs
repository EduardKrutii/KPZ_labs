using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Interfaces
{
    public interface ICart
    {
        void AddToCart(IProduct product, int quantity);
        void RemoveFromCart(string productName, int quantity);
        Dictionary<IProduct, int> GetCartItems();
        IMoney GetTotalPrice();
    }
}
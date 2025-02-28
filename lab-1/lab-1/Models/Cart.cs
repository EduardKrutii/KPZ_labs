using lab_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class Cart : ICart
    {
        private readonly Dictionary<IProduct, int> cartItems = new();

        public void AddToCart(IProduct product, int quantity)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (quantity <= 0) throw new ArgumentException("Кiлькiсть повинна бути бiльшою за 0.");

            if (cartItems.ContainsKey(product))
                cartItems[product] += quantity;
            else
                cartItems[product] = quantity;
        }

        public void RemoveFromCart(string productName, int quantity)
        {
            var product = cartItems.Keys.FirstOrDefault(p => p.Name == productName);
            if (product == null) throw new InvalidOperationException("Продукт не знайдено в кошику.");
            if (cartItems[product] < quantity) throw new InvalidOperationException("Недостатньо товару в кошику.");

            cartItems[product] -= quantity;
            if (cartItems[product] == 0) cartItems.Remove(product);
        }

        public Dictionary<IProduct, int> GetCartItems() => new(cartItems);

        public IMoney GetTotalPrice()
        {
            int totalWhole = cartItems.Sum(item => item.Key.Price.WholePart * item.Value);
            int totalFraction = cartItems.Sum(item => item.Key.Price.FractionalPart * item.Value);
            totalWhole += totalFraction / 100;
            totalFraction %= 100;

            return new USD(totalWhole, totalFraction);
        }
    }
}
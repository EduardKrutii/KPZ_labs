using lab_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class Warehouse : IWarehouse
    {
        private readonly Dictionary<IProduct, int> inventory = new();

        public void AddProduct(IProduct product, int quantity)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (quantity <= 0) throw new ArgumentException("Кiлькість має бути бiльше нуля.");

            if (inventory.ContainsKey(product))
                inventory[product] += quantity;
            else
                inventory[product] = quantity;
        }

        public void RemoveProduct(string productName, int quantity)
        {
            var product = inventory.Keys.FirstOrDefault(p => p.Name == productName);
            if (product == null) throw new InvalidOperationException("Продукт не знайдено.");
            if (inventory[product] < quantity) throw new InvalidOperationException("Недостатньо товару на складi.");

            inventory[product] -= quantity;
            if (inventory[product] == 0) inventory.Remove(product);
        }

        public Dictionary<IProduct, int> GetInventory() => new(inventory);

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var item in inventory)
            {
                result.AppendLine($"{item.Key.Name} ({item.Key.Category}): {item.Value} шт.");
            }
            return result.ToString();
        }
    }
}
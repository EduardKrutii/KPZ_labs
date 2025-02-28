using lab_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class Product : IProduct
    {
        public string Name { get; }
        public string Category { get; }
        public IMoney Price { get; private set; }

        public Product(string name, string category, IMoney price)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Category = category ?? throw new ArgumentNullException(nameof(category));
            Price = price ?? throw new ArgumentNullException(nameof(price));
        }

        public void ReducePrice(int amount)
        {
            if (amount < 0) throw new ArgumentException("Зменшення не може бути вiд'ємним.");
            int newWhole = Price.WholePart - amount;
            if (newWhole < 0) throw new InvalidOperationException("Цiна не може бути вiд'ємною.");
            Price = new Money(newWhole, Price.FractionalPart);
        }

        public override string ToString()
        {
            return $"{Name} ({Category}): {Price}";
        }
    }
}
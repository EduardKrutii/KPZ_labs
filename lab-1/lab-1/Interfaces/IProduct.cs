using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Interfaces
{
    public interface IProduct
    {
        string Name { get; }
        string Category { get; }
        IMoney Price { get; }
        void ReducePrice(int amount);
    }
}

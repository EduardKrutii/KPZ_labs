using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Interfaces
{
    public interface IWarehouse
    {
        void AddProduct(IProduct product, int quantity);
        void RemoveProduct(string productName, int quantity);
        Dictionary<IProduct, int> GetInventory();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Interfaces
{
    public interface IReporting
    {
        void GenerateInventoryReport(IWarehouse warehouse);
    }
}
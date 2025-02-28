using lab_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Services
{
    public class Reporting : IReporting
    {
        public void GenerateInventoryReport(IWarehouse warehouse)
        {
            Console.WriteLine("Iнвентаризацiя складу:");
            foreach (var item in warehouse.GetInventory())
            {
                Console.WriteLine($"{item.Key}: {item.Value} шт.");
            }
        }
    }
}
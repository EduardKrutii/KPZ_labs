using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechFactoryProject.Devices
{
    public class Smartphone : IDevice
    {
        private string _brand;
        public Smartphone(string brand) => _brand = brand;

        public string GetName() => $"{_brand} Smartphone";
    }
}
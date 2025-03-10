using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechFactoryProject.Devices
{
    public class EBook : IDevice
    {
        private string _brand;
        public EBook(string brand) => _brand = brand;

        public string GetName() => $"{_brand} E-Book";
    }
}
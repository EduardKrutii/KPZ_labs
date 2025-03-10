﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TechFactoryProject.Devices;

namespace TechFactoryProject.Factories
{
    public class IProneFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("IProne");
        public IDevice CreateNetbook() => new Netbook("IProne");
        public IDevice CreateEBook() => new EBook("IProne");
        public IDevice CreateSmartphone() => new Smartphone("IProne");
    }
}
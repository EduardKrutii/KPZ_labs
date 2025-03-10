using System;
using TechFactoryProject.Factories;
using TechFactoryProject.Devices;

class Program
{
    static void Main()
    {
        TestFactory(new IProneFactory());
        TestFactory(new KiaomiFactory());
        TestFactory(new BalaxyFactory());
    }

    static void TestFactory(IDeviceFactory factory)
    {
        Console.WriteLine($"Testing {factory.GetType().Name}:");
        IDevice laptop = factory.CreateLaptop();
        IDevice netbook = factory.CreateNetbook();
        IDevice ebook = factory.CreateEBook();
        IDevice smartphone = factory.CreateSmartphone();

        Console.WriteLine(laptop.GetName());
        Console.WriteLine(netbook.GetName());
        Console.WriteLine(ebook.GetName());
        Console.WriteLine(smartphone.GetName());
        Console.WriteLine();
    }
}
using lab_1.Interfaces;
using lab_1.Models;
using lab_1.Services;
using System;

class Program
{
    static void Main()
    {
        IMoney price1 = new USD(10, 50);
        IMoney price2 = new EUR(20, 75);

        IProduct product1 = new Product("Чай", "Напої", price1);
        IProduct product2 = new Product("Кава", "Напої", price2);

        IWarehouse warehouse = new Warehouse();
        warehouse.AddProduct(product1, 10);
        warehouse.AddProduct(product2, 5);

        IReporting reporting = new Reporting();
        Console.WriteLine("Звiт по iнвентаризацiї складу:");
        reporting.GenerateInventoryReport(warehouse);

        warehouse.RemoveProduct("Чай", 3);
        Console.WriteLine("\nЗвiт пiсля видалення 3 шт. чаю:");
        reporting.GenerateInventoryReport(warehouse);

        ICart cart = new Cart();
        cart.AddToCart(product1, 2);
        cart.AddToCart(product2, 1);

        Console.WriteLine("\nКошик покупок:");
        foreach (var item in cart.GetCartItems())
        {
            Console.WriteLine($"{item.Key.Name} x {item.Value}");
        }

        Console.WriteLine($"\nЗагальна сума: {cart.GetTotalPrice()}");
    }
}
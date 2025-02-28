using lab_1.Interfaces;
using lab_1.Models;
using lab_1.Services;
using System;

class TestProgram
{
    static void Main()
    {
        Console.WriteLine("==== ТЕСТУВАННЯ КЛАСIВ ====\n");

        // 1. Тестування Money
        IMoney usd = new USD(10, 50);
        IMoney eur = new EUR(20, 75);
        Console.WriteLine($"USD: {usd}");
        Console.WriteLine($"EUR: {eur}");

        // 2. Тестування Product
        IProduct product1 = new Product("Чай", "Напої", usd);
        IProduct product2 = new Product("Кава", "Напої", eur);
        Console.WriteLine($"\nПродукти:\n{product1}\n{product2}");

        // 3. Тестування Warehouse
        IWarehouse warehouse = new Warehouse();
        warehouse.AddProduct(product1, 10);
        warehouse.AddProduct(product2, 5);
        Console.WriteLine("\nСклад пiсля додавання товарiв:");
        Console.WriteLine(warehouse);

        warehouse.RemoveProduct("Чай", 3);
        Console.WriteLine("\nСклад пiсля видалення 3 шт. чаю:");
        Console.WriteLine(warehouse);

        // 4. Тестування Reporting
        IReporting reporting = new Reporting();
        Console.WriteLine("\nЗвiт по iнвентаризацiї:");
        reporting.GenerateInventoryReport(warehouse);

        // 5. Тестування Cart
        ICart cart = new Cart();
        cart.AddToCart(product1, 2);
        cart.AddToCart(product2, 1);

        Console.WriteLine("\nКошик покупок:");
        foreach (var item in cart.GetCartItems())
        {
            Console.WriteLine($"{item.Key.Name} x {item.Value}");
        }
        Console.WriteLine($"Загальна сума: {cart.GetTotalPrice()}");

        Console.WriteLine("\n==== ТЕСТУВАННЯ ЗАВЕРШЕНО ====");
    }
}
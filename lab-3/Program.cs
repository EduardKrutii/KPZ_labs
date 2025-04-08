using System;
using System.IO;
using lab_3.Decorators;
using lab_3.Bridge;
using lab_3.Proxy;
using lab_3.Composite;
using lab_3.Flyweight;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 1. Adapter ===");
        RunAdapterDemo();
        PrintSeparator();

        Console.WriteLine("=== 2. Decorator ===");
        RunDecoratorDemo();
        PrintSeparator();

        Console.WriteLine("=== 3. Bridge ===");
        RunBridgeDemo();
        PrintSeparator();

        Console.WriteLine("=== 4. Proxy ===");
        RunProxyDemo();
        PrintSeparator();

        Console.WriteLine("=== 5. Composite ===");
        RunCompositeDemo();
        PrintSeparator();

        Console.WriteLine("=== 6. Flyweight ===");
        RunFlyweightDemo();
        PrintSeparator();

        Console.WriteLine("Усi демонстрацiї виконано успiшно.");
    }

    static void PrintSeparator()
    {
        Console.WriteLine("\n-----------------------------\n");
    }

    static void RunAdapterDemo()
    {
        Console.WriteLine("== Console Logger ==");
        Logger consoleLogger = new Logger();
        consoleLogger.Log("Everything is fine.");
        consoleLogger.Warn("Something might be wrong.");
        consoleLogger.Error("Something went wrong!");

        Console.WriteLine("\n== File Logger ==");
        Logger fileLogger = new FileLoggerAdapter("log.txt");
        fileLogger.Log("Everything is fine (file).");
        fileLogger.Warn("Something might be wrong (file).");
        fileLogger.Error("Something went wrong (file).");

        Console.WriteLine("Check 'log.txt' for file logger output.");
    }

    static void RunDecoratorDemo()
    {
        IHero hero = new Warrior();
        hero = new Sword(hero);
        hero = new Sword(hero);
        hero = new Armor(hero);
        hero = new Ring(hero);

        IHero hero1 = new Mage();
        hero1 = new Sword(hero1);
        hero1 = new Armor(hero1);
        hero1 = new Armor(hero1);
        hero1 = new Ring(hero1);

        IHero hero2 = new Paladin();
        hero2 = new Sword(hero2);
        hero2 = new Armor(hero2);
        hero2 = new Ring(hero2);
        hero2 = new Ring(hero2);

        hero.Display();
        hero1.Display();
        hero2.Display();
    }

    static void RunBridgeDemo()
    {
        IRenderer vector = new VectorRenderer();
        IRenderer raster = new RasterRenderer();

        Shape circle = new Circle(vector);
        Shape square = new Square(raster);
        Shape triangle = new Triangle(vector);

        circle.Draw();
        square.Draw();
        triangle.Draw();
    }

    static void RunProxyDemo()
    {
        string safeFile = "test.txt";
        string deniedFile = "secret.txt";

        File.WriteAllText(safeFile, "Hello\nWorld");
        File.WriteAllText(deniedFile, "This should be restricted.");

        ITextReader reader = new SmartTextReader();
        ITextReader checker = new SmartTextChecker(reader);
        ITextReader locker = new SmartTextReaderLocker(checker, "secret");

        Console.WriteLine("Reading allowed file:");
        locker.ReadFile(safeFile);

        Console.WriteLine("\nReading restricted file:");
        locker.ReadFile(deniedFile);
    }

    static void RunCompositeDemo()
    {
        var div = new LightElementNode("div", DisplayType.Block, ClosingType.Double);
        div.AddClass("container");

        var ul = new LightElementNode("ul", DisplayType.Block, ClosingType.Double);
        ul.AddClass("list");

        for (int i = 1; i <= 3; i++)
        {
            var li = new LightElementNode("li", DisplayType.Block, ClosingType.Double);
            li.AddClass("item");
            li.AddChild(new LightTextNode($"Item {i}"));
            ul.AddChild(li);
        }

        div.AddChild(ul);

        Console.WriteLine("Outer HTML:\n" + div.OuterHTML);
        Console.WriteLine("\nInner HTML:\n" + div.InnerHTML);
    }

    static void RunFlyweightDemo()
    {
        var lines = new[]
        {
            "The Great Gatsby",
            "By F. Scott Fitzgerald",
            " ",
            "In my younger and more vulnerable years my father gave me some advice...",
            "   He didn't say any more...",
            "Reserving judgments is a matter of infinite hope..."
        };

        var renderer = new BookHtmlRenderer();
        renderer.RenderBook(lines);
        renderer.Display();
    }
}
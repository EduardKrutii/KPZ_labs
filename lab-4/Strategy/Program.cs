using Strategy;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileLoadStrategy = new FileLoadStrategy();
            var networkLoadStrategy = new NetworkLoadStrategy();

            var imageElement = new ImageElementNode("img", DisplayType.Block, ClosingType.Single, fileLoadStrategy);
            Console.WriteLine(imageElement.LoadImage("image.jpg"));

            imageElement.SetLoadStrategy(networkLoadStrategy);
            Console.WriteLine(imageElement.LoadImage("http://example.com/image.jpg"));
        }
    }
}
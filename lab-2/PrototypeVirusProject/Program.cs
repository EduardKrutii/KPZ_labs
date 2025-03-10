using System;

namespace PrototypeVirusProject
{
    class Program
    {
        static void Main()
        {
            Virus parentVirus = new Virus("Corona-X", "RNA", 2.5, 10);

            Virus child1 = new Virus("Corona-X1", "RNA", 1.2, 5);
            Virus child2 = new Virus("Corona-X2", "RNA", 1.1, 4);
            parentVirus.AddChild(child1);
            parentVirus.AddChild(child2);

            Virus grandChild1 = new Virus("Corona-X1.1", "RNA", 0.6, 2);
            child1.AddChild(grandChild1);

            Console.WriteLine("Original Virus:");
            parentVirus.Print();

            Virus clonedVirus = parentVirus.Clone();
            Console.WriteLine("\nCloned Virus:");
            clonedVirus.Print();
        }
    }
}
using System;
using System.Collections.Generic;

namespace PrototypeVirusProject
{
    public class Virus
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, string type, double weight, int age)
        {
            Name = name;
            Type = type;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public Virus Clone()
        {
            Virus clonedVirus = new Virus(Name, Type, Weight, Age);
            foreach (var child in Children)
            {
                clonedVirus.Children.Add(child.Clone());
            }
            return clonedVirus;
        }

        public void Print(int level = 0)
        {
            Console.WriteLine($"{new string('-', level * 2)}> {Name} ({Type}), {Weight}g, {Age} days old");
            foreach (var child in Children)
            {
                child.Print(level + 1);
            }
        }
    }
}
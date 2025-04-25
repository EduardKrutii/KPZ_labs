using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft? OccupiedBy { get; private set; }

        public bool IsFree => OccupiedBy == null;

        public void Occupy(Aircraft aircraft)
        {
            OccupiedBy = aircraft;
            Console.WriteLine($"Runway {Id} is now occupied by aircraft {aircraft.Name}.");
            HighlightRed();
        }

        public void Release()
        {
            Console.WriteLine($"Runway {Id} is now free.");
            OccupiedBy = null;
            HighlightGreen();
        }

        public void HighlightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighlightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new();

        public CommandCentre(IEnumerable<Runway> runways)
        {
            _runways.AddRange(runways);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting landing...");

            var availableRunway = _runways.FirstOrDefault(r => r.IsFree);
            if (availableRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {availableRunway.Id}.");
                availableRunway.Occupy(aircraft);
            }
            else
            {
                Console.WriteLine("No free runways. Landing denied.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting take-off...");

            var runway = _runways.FirstOrDefault(r => r.OccupiedBy == aircraft);
            if (runway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {runway.Id}.");
                runway.Release();
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}
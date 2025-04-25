using Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }

        private CommandCentre _commandCentre;

        public Aircraft(string name, CommandCentre commandCentre)
        {
            Name = name;
            _commandCentre = commandCentre;
        }

        public void RequestLanding()
        {
            _commandCentre.RequestLanding(this);
        }

        public void RequestTakeOff()
        {
            _commandCentre.RequestTakeOff(this);
        }
    }
}
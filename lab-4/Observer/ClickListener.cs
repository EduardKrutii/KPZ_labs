using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ClickListener : IEventListener
    {
        private readonly string _name;

        public ClickListener(string name)
        {
            _name = name;
        }

        public void HandleEvent(string eventType)
        {
            Console.WriteLine($"{_name} clicked!");
        }
    }
}
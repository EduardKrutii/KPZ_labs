using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private Memento _memento;

        public void SaveState(Memento memento)
        {
            _memento = memento;
        }

        public Memento RestoreState()
        {
            return _memento;
        }
    }
}
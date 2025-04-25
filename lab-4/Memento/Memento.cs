using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        public string Text { get; private set; }
        public Memento(string text)
        {
            Text = text;
        }
    }
}
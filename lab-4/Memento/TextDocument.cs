using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextDocument
    {
        public string Text { get; set; } = string.Empty;

        public Memento CreateMemento()
        {
            return new Memento(Text);
        }

        public void RestoreMemento(Memento memento)
        {
            Text = memento.Text;
        }
    }
}
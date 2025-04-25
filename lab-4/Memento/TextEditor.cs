using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private TextDocument _document = new TextDocument();
        private Caretaker _caretaker = new Caretaker();

        public void AddText(string text)
        {
            _document.Text += text;
        }

        public string GetText()
        {
            return _document.Text;
        }

        public void Save()
        {
            _caretaker.SaveState(_document.CreateMemento());
        }

        public void Undo()
        {
            var memento = _caretaker.RestoreState();
            if (memento != null)
            {
                _document.RestoreMemento(memento);
            }
        }
    }
}
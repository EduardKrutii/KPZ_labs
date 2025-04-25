using Memento;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();
            editor.AddText("Hello, world!");
            Console.WriteLine(editor.GetText());

            editor.Save();

            editor.AddText(" How are you?");
            Console.WriteLine(editor.GetText());

            editor.Undo();
            Console.WriteLine(editor.GetText());
        }
    }
}
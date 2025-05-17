using System;
using Custom_HTML_Engine.Command;
using Custom_HTML_Engine.Elements;
using Custom_HTML_Engine.Iterator;
using Custom_HTML_Engine.State;
using Custom_HTML_Engine.Visitor;

namespace Custom_HTML_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Div();
            root.SetText("Root div");

            var p1 = new Paragraph();
            p1.SetText("Paragraph 1");

            var p2 = new Paragraph();
            p2.SetText("Paragraph 2");

            ICommand add1 = new AddElementCommand(root, p1);
            ICommand add2 = new AddElementCommand(root, p2);

            add1.Execute();
            add2.Execute();

            root.SetState(new LoadingState());
            root.Render();
            root.SetState(new RenderedState());

            Console.WriteLine("\nTraversal:");
            var iterator = new DepthFirstIterator(root);
            while (iterator.HasNext())
            {
                var el = iterator.Next();
                Console.WriteLine($"Element: {el.GetType().Name}");
            }

            Console.WriteLine("\nVisitor:");
            var visitor = new CountVisitor();
            root.Accept(visitor);
            foreach (var child in root.GetChildren())
                child.Accept(visitor);

            Console.WriteLine($"Divs: {visitor.DivCount}, Paragraphs: {visitor.ParagraphCount}");
        }
    }
}
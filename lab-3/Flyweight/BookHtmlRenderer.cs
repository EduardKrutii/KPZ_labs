using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_3.Composite;

namespace lab_3.Flyweight
{
    public class BookHtmlRenderer
    {
        private readonly HtmlElementFactory _factory = new();
        private readonly List<LightElementNode> _nodes = new();

        public void RenderBook(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string tag = i == 0 ? "h1" :
                             lines[i].StartsWith(" ") ? "blockquote" :
                             lines[i].Length < 20 ? "h2" : "p";

                var flyweight = _factory.GetElement(tag);
                var element = flyweight.CreateNode();
                element.AddChild(new LightTextNode(lines[i]));
                _nodes.Add(element);
            }
        }

        public void Display()
        {
            foreach (var node in _nodes)
            {
                Console.WriteLine(node.OuterHTML);
            }

            Console.WriteLine($"\nTotal nodes: {_nodes.Count}");
            Console.WriteLine($"Flyweight elements shared: {_factory.SharedCount}");
        }
    }
}
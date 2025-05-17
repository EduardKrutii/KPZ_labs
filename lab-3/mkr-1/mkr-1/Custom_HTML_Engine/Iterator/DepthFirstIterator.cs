using Custom_HTML_Engine.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_HTML_Engine.Iterator
{
    public class DepthFirstIterator : IHtmlIterator
    {
        private Stack<HtmlElement> stack = new();

        public DepthFirstIterator(HtmlElement root)
        {
            stack.Push(root);
        }

        public bool HasNext() => stack.Count > 0;

        public HtmlElement Next()
        {
            var current = stack.Pop();
            foreach (var child in current.GetChildren())
                stack.Push(child);
            return current;
        }
    }
}
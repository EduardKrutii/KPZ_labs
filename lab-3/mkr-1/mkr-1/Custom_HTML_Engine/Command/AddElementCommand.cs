using Custom_HTML_Engine.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_HTML_Engine.Command
{
    public class AddElementCommand : ICommand
    {
        private HtmlElement parent, child;

        public AddElementCommand(HtmlElement parent, HtmlElement child)
        {
            this.parent = parent;
            this.child = child;
        }

        public void Execute() => parent.AddChild(child);
    }
}
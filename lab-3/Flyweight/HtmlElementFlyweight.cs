using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_3.Composite;

namespace lab_3.Flyweight
{
    public class HtmlElementFlyweight
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public ClosingType Closing { get; }

        public HtmlElementFlyweight(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
        }

        public LightElementNode CreateNode() =>
            new LightElementNode(TagName, Display, Closing);
    }
}
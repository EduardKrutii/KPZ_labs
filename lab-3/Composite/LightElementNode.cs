using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Composite
{
    public enum DisplayType { Block, Inline }
    public enum ClosingType { Single, Double }

    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public ClosingType Closing { get; }
        public List<string> CssClasses { get; } = new();
        public List<LightNode> Children { get; } = new();

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
        }

        public void AddClass(string className) => CssClasses.Add(className);
        public void AddChild(LightNode node) => Children.Add(node);

        public override string InnerHTML => string.Join("", Children.Select(c => c.OuterHTML));

        public override string OuterHTML
        {
            get
            {
                string classes = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                if (Closing == ClosingType.Single)
                    return $"<{TagName}{classes} />";
                else
                    return $"<{TagName}{classes}>{InnerHTML}</{TagName}>";
            }
        }
    }
}
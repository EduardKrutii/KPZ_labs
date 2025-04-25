using Observer;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var div = new LightElementNode("div", DisplayType.Block, ClosingType.Double);
            var paragraph = new LightElementNode("p", DisplayType.Block, ClosingType.Double);
            paragraph.AddChild(new LightTextNode("Hello, world!"));

            div.AddEventListener("click", new ClickListener("Div"));
            paragraph.AddEventListener("click", new ClickListener("Paragraph"));

            div.TriggerEvent("click");
            paragraph.TriggerEvent("click");
        }
    }
}
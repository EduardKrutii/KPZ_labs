using System;
using Custom_HTML_Engine.Visitor;
using Custom_HTML_Engine.State;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_HTML_Engine.Elements
{
    public abstract class HtmlElement
    {
        protected List<HtmlElement> children = new();
        protected string text;
        protected IElementState state = new RenderedState();

        public void Render()
        {
            OnCreated();
            OnInserted();
            OnStylesApplied();
            OnClassListApplied();
            OnTextRendered();
            foreach (var child in children)
                child.Render();
        }

        public virtual void AddChild(HtmlElement element) => children.Add(element);
        public void SetText(string text) => this.text = text;

        protected virtual void OnCreated() => Console.WriteLine($"[{GetType().Name}] OnCreated");
        protected virtual void OnInserted() => Console.WriteLine($"[{GetType().Name}] OnInserted");
        protected virtual void OnStylesApplied() => Console.WriteLine($"[{GetType().Name}] OnStylesApplied");
        protected virtual void OnClassListApplied() => Console.WriteLine($"[{GetType().Name}] OnClassListApplied");
        protected virtual void OnTextRendered() => Console.WriteLine($"[{GetType().Name}] OnTextRendered: {text}");

        public abstract void Accept(IHtmlVisitor visitor);
        public void SetState(IElementState newState)
        {
            state = newState;
            state.Handle(this);
        }

        public List<HtmlElement> GetChildren() => children;
    }
}
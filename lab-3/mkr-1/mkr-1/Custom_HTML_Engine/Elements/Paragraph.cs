using System;
using Custom_HTML_Engine.Visitor;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_HTML_Engine.Elements
{
    public class Paragraph : HtmlElement
    {
        public override void Accept(IHtmlVisitor visitor) => visitor.VisitParagraph(this);
    }
}
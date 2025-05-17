using Custom_HTML_Engine.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_HTML_Engine.Visitor
{
    public interface IHtmlVisitor
    {
        void VisitDiv(Div div);
        void VisitParagraph(Paragraph p);
    }
}
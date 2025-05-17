using Custom_HTML_Engine.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_HTML_Engine.Visitor
{
    public class CountVisitor : IHtmlVisitor
    {
        public int DivCount = 0;
        public int ParagraphCount = 0;

        public void VisitDiv(Div div) => DivCount++;
        public void VisitParagraph(Paragraph p) => ParagraphCount++;
    }
}
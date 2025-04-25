using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class Level1Support : SupportHandler
    {
        public override bool Handle(SupportRequest request)
        {
            if (request.IssueType == "1")
            {
                Console.WriteLine("Level 1 Support: Handled the issue.");
                return true;
            }
            return NextHandler?.Handle(request) ?? false;
        }
    }
}
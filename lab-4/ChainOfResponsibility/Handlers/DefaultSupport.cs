using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class DefaultSupport : SupportHandler
    {
        public override bool Handle(SupportRequest request)
        {
            Console.WriteLine("Sorry, your issue could not be resolved. Please try again.");
            return false;
        }
    }
}
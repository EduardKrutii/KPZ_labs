using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public abstract class SupportHandler
    {
        protected SupportHandler? NextHandler;

        public void SetNext(SupportHandler next)
        {
            NextHandler = next;
        }

        public abstract bool Handle(SupportRequest request);
    }
}
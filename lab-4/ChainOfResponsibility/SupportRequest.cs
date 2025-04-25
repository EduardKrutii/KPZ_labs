using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SupportRequest
    {
        public string IssueType { get; set; }

        public SupportRequest(string issueType)
        {
            IssueType = issueType;
        }
    }
}
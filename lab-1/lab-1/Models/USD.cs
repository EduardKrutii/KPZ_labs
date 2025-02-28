using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class USD : Money
    {
        public USD(int dollars, int cents) : base(dollars, cents) { }

        public override string ToString()
        {
            return $"${base.ToString()} USD";
        }
    }
}
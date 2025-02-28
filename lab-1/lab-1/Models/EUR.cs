using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class EUR : Money
    {
        public EUR(int euros, int cents) : base(euros, cents) { }

        public override string ToString()
        {
            return $"{base.ToString()} EUR";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class UAH : Money
    {
        public UAH(int hryvnias, int kopecks) : base(hryvnias, kopecks) { }

        public override string ToString()
        {
            return $"{wholePart}.{fractionalPart:D2} UAH";
        }
    }
}
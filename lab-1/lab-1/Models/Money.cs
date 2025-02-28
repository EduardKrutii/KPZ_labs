using lab_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class Money : IMoney
    {
        protected int wholePart;
        protected int fractionalPart;

        public Money(int wholePart, int fractionalPart)
        {
            SetMoney(wholePart, fractionalPart);
        }

        public int WholePart => wholePart;
        public int FractionalPart => fractionalPart;

        public virtual void SetMoney(int wholePart, int fractionalPart)
        {
            if (wholePart < 0 || fractionalPart < 0)
                throw new ArgumentException("Грошовi значення не можуть бути вiд'ємними.");

            this.wholePart = wholePart;
            this.fractionalPart = fractionalPart;
        }

        public override string ToString()
        {
            return $"{wholePart}.{fractionalPart:D2}";
        }
    }
}
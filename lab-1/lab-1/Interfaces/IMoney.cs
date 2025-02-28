using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Interfaces
{
    public interface IMoney
    {
        int WholePart { get; }
        int FractionalPart { get; }
        void SetMoney(int wholePart, int fractionalPart);
        string ToString();
    }
}

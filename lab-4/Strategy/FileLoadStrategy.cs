using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FileLoadStrategy : ILoadStrategy
    {
        public string Load(string source)
        {
            return $"Loading image from file: {source}";
        }
    }
}
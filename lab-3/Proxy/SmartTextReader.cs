using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Proxy
{
    public class SmartTextReader : ITextReader
    {
        public char[][] ReadFile(string path)
        {
            var lines = File.ReadAllLines(path);
            var result = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }

            return result;
        }
    }
}
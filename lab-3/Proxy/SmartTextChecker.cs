using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Proxy
{
    public class SmartTextChecker : ITextReader
    {
        private readonly ITextReader _reader;

        public SmartTextChecker(ITextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadFile(string path)
        {
            Console.WriteLine($"[Checker] Opening file: {path}");

            char[][] data = _reader.ReadFile(path);

            Console.WriteLine($"[Checker] Successfully read file: {path}");
            Console.WriteLine($"[Checker] Lines: {data.Length}");
            Console.WriteLine($"[Checker] Total characters: {data.Sum(line => line.Length)}");

            return data;
        }
    }
}
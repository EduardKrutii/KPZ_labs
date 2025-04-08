using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_3.Proxy
{
    public class SmartTextReaderLocker : ITextReader
    {
        private readonly ITextReader _reader;
        private readonly Regex _restrictedPattern;

        public SmartTextReaderLocker(ITextReader reader, string pattern)
        {
            _reader = reader;
            _restrictedPattern = new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public char[][] ReadFile(string path)
        {
            if (_restrictedPattern.IsMatch(path))
            {
                Console.WriteLine("[Locker] Access denied!");
                return Array.Empty<char[]>();
            }

            return _reader.ReadFile(path);
        }
    }
}
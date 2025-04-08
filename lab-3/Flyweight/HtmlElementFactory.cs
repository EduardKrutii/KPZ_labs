using lab_3.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Flyweight
{
    public class HtmlElementFactory
    {
        private readonly Dictionary<string, HtmlElementFlyweight> _cache = new();

        public HtmlElementFlyweight GetElement(string tag)
        {
            if (!_cache.ContainsKey(tag))
            {
                var (display, closing) = tag switch
                {
                    "h1" or "h2" or "blockquote" or "p" => (DisplayType.Block, ClosingType.Double),
                    _ => (DisplayType.Inline, ClosingType.Single)
                };

                _cache[tag] = new HtmlElementFlyweight(tag, display, closing);
            }

            return _cache[tag];
        }

        public int SharedCount => _cache.Count;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ImageElementNode : LightElementNode
    {
        private ILoadStrategy _loadStrategy;

        public ImageElementNode(string tagName, DisplayType display, ClosingType closing, ILoadStrategy loadStrategy)
            : base(tagName, display, closing)
        {
            _loadStrategy = loadStrategy;
        }

        public void SetLoadStrategy(ILoadStrategy newStrategy)
        {
            _loadStrategy = newStrategy;
        }

        public string LoadImage(string source)
        {
            return _loadStrategy.Load(source);
        }
    }
}
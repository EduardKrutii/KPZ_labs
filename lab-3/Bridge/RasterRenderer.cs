﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Bridge
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as pixels.");
        }
    }
}
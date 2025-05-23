﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Bridge
{
    public abstract class Shape
    {
        protected IRenderer Renderer;

        public Shape(IRenderer renderer)
        {
            Renderer = renderer;
        }

        public abstract void Draw();
    }
}
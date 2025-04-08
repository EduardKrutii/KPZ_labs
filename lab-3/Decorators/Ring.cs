﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Decorators
{
    public class Ring : HeroDecorator
    {
        public Ring(IHero hero) : base(hero) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(" + equipped with a ring");
        }
    }
}
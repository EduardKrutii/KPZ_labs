﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Decorators
{
    public class Paladin : IHero
    {
        public void Display()
        {
            Console.WriteLine("Paladin");
        }
    }
}
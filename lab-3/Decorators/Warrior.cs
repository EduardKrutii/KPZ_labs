﻿using lab_3.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Decorators
{
    public class Warrior : IHero
    {
        public void Display()
        {
            Console.WriteLine("Warrior");
        }
    }
}
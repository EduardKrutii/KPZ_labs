using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.Decorators
{
    public abstract class HeroDecorator : IHero
    {
        protected IHero _hero;

        protected HeroDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual void Display()
        {
            _hero.Display();
        }
    }
}
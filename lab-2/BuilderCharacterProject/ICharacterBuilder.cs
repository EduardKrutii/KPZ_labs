using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCharacterProject
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetAppearance(string appearance);
        ICharacterBuilder SetWeapon(string weapon);
        ICharacterBuilder AddAbility(string ability);
        Character Build();
    }
}
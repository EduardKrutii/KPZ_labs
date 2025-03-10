using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCharacterProject
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character { Role = "Лиходiй" };

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetAppearance(string appearance)
        {
            _character.Appearance = appearance;
            return this;
        }

        public ICharacterBuilder SetWeapon(string weapon)
        {
            _character.Weapon = weapon;
            return this;
        }

        public ICharacterBuilder AddAbility(string ability)
        {
            _character.Abilities.Add(ability);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}
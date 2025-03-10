using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCharacterProject
{
    public class CharacterDirector
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder.SetName("Артемiс")
                          .SetAppearance("Високий, срiбне волосся")
                          .SetWeapon("Меч долi")
                          .AddAbility("Швидкiсть")
                          .AddAbility("Телепортацiя")
                          .Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder.SetName("Моргат")
                          .SetAppearance("Темний плащ, палаючi очi")
                          .SetWeapon("Жезл хаосу")
                          .AddAbility("Некромантiя")
                          .AddAbility("Прокляття")
                          .Build();
        }
    }
}
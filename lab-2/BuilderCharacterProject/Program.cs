using System;

namespace BuilderCharacterProject
{
    class Program
    {
        static void Main()
        {
            CharacterDirector director = new CharacterDirector();

            ICharacterBuilder heroBuilder = new HeroBuilder();
            Character hero = director.CreateHero(heroBuilder);

            ICharacterBuilder enemyBuilder = new EnemyBuilder();
            Character enemy = director.CreateEnemy(enemyBuilder);

            Console.WriteLine(hero);
            Console.WriteLine(enemy);
        }
    }
}

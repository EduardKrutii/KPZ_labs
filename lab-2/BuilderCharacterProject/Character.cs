using System;
using System.Collections.Generic;

namespace BuilderCharacterProject
{
    public class Character
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Appearance { get; set; }
        public string Weapon { get; set; }
        public List<string> Abilities { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"{Role}: {Name}\nЗовнiшнiсть: {Appearance}\nЗброя: {Weapon}\nВмiння: {string.Join(", ", Abilities)}\n";
        }
    }
}
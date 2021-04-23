using System;

namespace DotaHeroes
{
    public class Spell
    {
        public int StrengthLvlSpell = default;
        public string Name { get; }
        public double CallDown { get; set; }
        public string Discription { get; set; }
        public double Damage { get; set; }
        public bool IsStun { get; set; }

        public Spell(string name)
        {
            Name = name;
        }
        
        public Spell()
        {
            Random rnd = new Random();
            StrengthLvlSpell = rnd.Next(1, 100);
        }

        public int GetStrengthSpell()
        {
            return StrengthLvlSpell;
        }
    }
    
}
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace DotaHeroes
{
    public class DotaHero
    {
        //енто поле 
        private List<Spell> _spells = new List<Spell>();
        public int StrengthLvl = default;

        public string Name { get; set; }
        public string Attack { get; set; }
        public string[] Role { get; set; }
        public int SpellsCount { get; set; }
        public bool IsShardAddSpell { get; set; }

        public double Power
        {
            get
            {
                double allDamage = _spells.Select(x => x.Damage).Sum();
                return allDamage + StrengthLvl;
            }
        }

        public DotaHero()
        {
            Random rnd = new Random();
            StrengthLvl = rnd.Next(1, 100);
        }

        public int GetStrength()
        {
            return StrengthLvl;
        }

        public void AddSpell(Spell spell)
        {
            _spells.Add(spell);
        }

        //объясняю тупому c# что dotahero надо вывести строкой
        public override string ToString()
        {
            return Name + " " + Power;
        }
        
    }
}
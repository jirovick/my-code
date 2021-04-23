using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;

namespace DotaHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DotaHero> heroes = HeroesHelper.CreateHeroes();
            List<Spell> spells = HeroesHelper.HeroesSpells();

            foreach (var hero in heroes)
            {
                for (int i = 0; i < hero.SpellsCount; i++)
                {
                    //получил один спел
                    //присвоил этот спел
                    Spell a1 = HeroesHelper.GetRandomSpell(spells);
                    hero.AddSpell(a1);
                }
            }

            DotaHero end = Figth(heroes[1], heroes[0]);
            Console.WriteLine(end);
            Console.ReadKey();
            
        }

        public static DotaHero Figth(DotaHero name1, DotaHero name2)
        {
            if (name1.Power > name2.Power)
            {
                
                return name1;
            }

            
            return name2;
        }
    }
}
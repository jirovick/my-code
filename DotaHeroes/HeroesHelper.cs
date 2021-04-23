using System;
using System.Collections.Generic;

namespace DotaHeroes
{
    public class HeroesHelper
    {
        public static List<DotaHero> CreateHeroes()
        {
            DotaHero ancientApparition = new DotaHero
            {
                Name = "Ancient Apparition",
                Attack = "Range",
                Role = new string[] {"Support", "Nuker", "Disabler"},
                SpellsCount = 4,
                IsShardAddSpell = false,
            };

            DotaHero keeperOfTheLight = new DotaHero
            {
                Name = "Keeper Of The Light",
                Attack = "Range",
                Role = new[] {"Disabler", "Jungler", "Nuker", "Support"},
                SpellsCount = 4,
                IsShardAddSpell = true,
            };

            DotaHero antiMage = new DotaHero
            {
                Name = "Anti-Mage",
                Attack = "Melee",
                Role = new[] {"Carry", "Escape", "Nuker"},
                SpellsCount = 4,
                IsShardAddSpell = false,
            };

            DotaHero terrorBlade = new DotaHero
            {
                Name = "Terrorblade",
                Attack = "Swappable",
                Role = new[] {"Carry", "Nuker", "Pusher"},
                SpellsCount = 4,
                IsShardAddSpell = true,
            };

            DotaHero lina = new DotaHero
            {
                Name = "Lina",
                Attack = "Range",
                Role = new[] {"Carry", "Disabler", "Nuker", "Support"},
                SpellsCount = 4,
                IsShardAddSpell = false,
            };
            List<DotaHero> heroList = new List<DotaHero>
            {
                lina,
                ancientApparition,
                terrorBlade,
                keeperOfTheLight,
                antiMage
            };
            return heroList;



        }

        public static List<Spell> HeroesSpells()
        {
            Spell iceBlast = new Spell("IceBlast")
            {
                CallDown = 40,
                Discription = "летит шар, а потом еще один и происходит боль",
                Damage = 450,
                IsStun = false,
            };

            Spell lagunaBlade = new Spell("Laguna Blade")
            {
                CallDown = 60,
                Discription = "aaa",
                Damage = 90,
                IsStun = false,
            };

            Spell manaVoid = new Spell("Mana Void")
            {
                CallDown = 60,
                Discription = "da",
                Damage = 100,
                IsStun = false,
            };

            Spell sunder = new Spell("Sunder")
            {
                CallDown = 50,
                Discription = "net",
                Damage = 0,
                IsStun = false,
            };

            Spell gust = new Spell("Gust")
            {
                CallDown = 13,
                Discription = "1",
                Damage = 0,
                IsStun = false,
            };
            
            Spell telekinesis = new Spell("Telekinesis")
            {
                CallDown = 22,
                Discription = "2",
                Damage = 0,
                IsStun = true,
            };
            
            Spell rupture = new Spell("Rupture")
            {
                CallDown = 50,
                Discription = "3",
                Damage = 100,
                IsStun = false,
            };
            
            Spell spiritForm = new Spell("Spirit Form")
            {
                CallDown = 75,
                Discription = "4",
                Damage = 0,
                IsStun = false,
            };
            
            Spell snowBall = new Spell("Snow Ball")
            {
                CallDown = 15,
                Discription = "5",
                Damage = 150,
                IsStun = true,
            };

            Spell burrowStrike = new Spell("Borrowstrike")
            {
                CallDown = 15,
                Discription = "5",
                Damage = 250,
                IsStun = true,
            };
            
            
            List<Spell> spellsList = new List<Spell>
            {
               iceBlast,
               lagunaBlade,
               sunder,
               manaVoid,
               spiritForm,
               burrowStrike,
               rupture,
               snowBall,
               gust,
               telekinesis,
            };
            return spellsList;
        }

        public static Spell GetRandomSpell(List<Spell> spells)
        {
            var rnd = new Random();
            var index = rnd.Next(0, spells.Count);
            return spells[index];
        }
        

        
    }
}
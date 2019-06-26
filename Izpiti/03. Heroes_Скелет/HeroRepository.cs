using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        // constructor should initialize the data with a new instance of the collection.Implement the following features:
        //     • Field data – collection that holds added heroes
        //     • Method Add(Hero hero) – adds an entity to the data.
        //     • Method Remove(string name) – removes an entity by given hero name.
        //     • Method GetHeroWithHighestStrength() – returns the Hero which poses the item with the highest stength.
        //     • Method GetHeroWithHighestAbility() – returns the Hero which poses the item with the highest ability.
        //     • Method GetHeroWithHighestIntelligence() – returns the Hero which poses the item with the highest intellgence.
        //     • Getter Count – returns the number of stored heroes.
        //     • Оverride ToString() – Print all the heroes.

        private Dictionary<string, Hero> heros;

        public int Count
        {
            get { return heros.Count; }
        }

        public Dictionary<string, Hero> Heros { get; set; }

        public HeroRepository()
        {
            heros = new Dictionary<string, Hero>();
        }

        public void Add(Hero hero)
        {
            heros.Add(hero.Name, hero);
        }

        public void Remove(string name)
        {
            heros.Remove(name);
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero resultHero = new Hero();
            int maxTotal = 0;

            foreach (var hero in heros)
            {
                int currentTotal = hero.Value.Item.Strength;
                if (maxTotal < currentTotal)
                {
                    maxTotal = currentTotal;
                    resultHero = hero.Value;
                }
            }
            return resultHero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero resultHero = new Hero();
            int maxTotal = 0;

            foreach (var hero in heros)
            {
                int currentTotal = hero.Value.Item.Ability;
                if (maxTotal < currentTotal)
                {
                    maxTotal = currentTotal;
                    resultHero = hero.Value;
                }
            }
            return resultHero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero resultHero = new Hero();
            int maxTotal = 0;

            foreach (var hero in heros)
            {
                int currentTotal = hero.Value.Item.Intelligence;
                if (maxTotal < currentTotal)
                {
                    maxTotal = currentTotal;
                    resultHero = hero.Value;
                }
            }
            return resultHero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
                   
            foreach (var hero in heros)
            {
                sb.AppendLine(hero.Value.ToString());                
            }
            return sb.ToString();
        }
    }
}

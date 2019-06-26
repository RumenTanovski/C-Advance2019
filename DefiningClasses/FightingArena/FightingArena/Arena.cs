using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private Dictionary<string, Gladiator> gladiators;
        public string Name { get; set; }
        public int Count
        {
            get { return gladiators.Count; }
        }

        public Arena(string name)
        {
            Name = name;
            gladiators = new Dictionary<string, Gladiator>();
        }
  
        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator.Name, gladiator);
        }

        public void Remove(string name)
        {
            gladiators.Remove(name);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
           Gladiator resultGladiator = new Gladiator();                      
           int maxTotal = 0;
           
           foreach (var gladiator in gladiators)
           {
                int currentTotal = gladiator.Value.GetStatPower(gladiator.Value.Stat);
                if (maxTotal<currentTotal)
                {
                    maxTotal = currentTotal;                    
                    resultGladiator = gladiator.Value;
                }           
           }           
            return resultGladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator resultGladiator = new Gladiator();
            int maxTotal = 0;

            foreach (var gladiator in gladiators)
            {
                int currentTotal = gladiator.Value.GetWeaponPower(gladiator.Value.Weapon);
                if (maxTotal < currentTotal)
                {
                    maxTotal = currentTotal;
                    resultGladiator = gladiator.Value;
                }
            }
            return resultGladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator resultGladiator = new Gladiator();
            int maxTotal = 0;

            foreach (var gladiator in gladiators)
            {
                int currentTotal = gladiator.Value.GetTotalPower(gladiator.Value.Stat ,gladiator.Value.Weapon);
                if (maxTotal < currentTotal)
                {
                    maxTotal = currentTotal;
                    resultGladiator = gladiator.Value;
                }
            }
            return resultGladiator;
        }

        public override string ToString()
        {
            string result = $"{Name} - {Count} gladiators are participating.";
            return result;
        }
    }
}

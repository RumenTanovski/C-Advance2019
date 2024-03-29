﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }
        public int Count => this.gladiators.Count;

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator gladiatoForRemove = this.gladiators
                .FirstOrDefault(g => g.Name == name);
            this.gladiators.Remove(gladiatoForRemove);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
           return this.gladiators.OrderByDescending(g => g.GetStatPower())
                .First();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return this.gladiators.OrderByDescending(g => g.GetWeaponPower())
                 .First();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return this.gladiators.OrderByDescending(g => g.GetTotalPower())
                 .First();
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}

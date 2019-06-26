using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            return GetWeaponPower() + GetStatPower();
        }

        public int GetWeaponPower()
        {
            return this.Weapon.Size + this.Weapon.Solidity + this.Weapon.Sharpness;
        }

        public int GetStatPower()
        {
            return Stat.Strength + Stat.Flexibility
                + Stat.Agility + Stat.Skills
                + Stat.Intelligence;
        }

        public override string ToString()
        {
            string result = $"[{this.Name}] - [{GetTotalPower()}]"
        + Environment.NewLine
        + $"  Weapon Power: [{GetWeaponPower()}]"
        + Environment.NewLine
        + $"  Stat Power: [{GetStatPower()}]";

            return result;
        }

    }
}

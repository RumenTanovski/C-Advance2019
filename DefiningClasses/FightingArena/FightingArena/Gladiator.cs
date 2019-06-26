using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {

        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public Gladiator()
        {
        }

        public Gladiator(string name, Stat stat, Weapon weapon):this()
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }
        
        public int GetTotalPower(Stat stat, Weapon weapon)
        {
            int result = GetStatPower(stat) + GetWeaponPower(weapon);
            return result;
        }

        public int GetWeaponPower(Weapon weapon)
        {
            int result = weapon.Size + weapon.Solidity + weapon.Sharpness;
            return result;
        }

        public int GetStatPower(Stat stat)
        {
            int result = stat.Strength + stat.Flexibility + stat.Agility + stat.Skills + stat.Intelligence;
            return result;
        }

        public override string ToString()
        {
            int weaponPower = GetWeaponPower(Weapon);
            int statPower = GetStatPower(Stat);
            int totalPower = GetTotalPower(Stat, Weapon);
            string result = $"{Name} - {totalPower}" +
                Environment.NewLine +
                $"  Weapon Power: {weaponPower}" +
                Environment.NewLine +
                $"  Stat Power: {Stat}";

            return result;
        }

    }
}

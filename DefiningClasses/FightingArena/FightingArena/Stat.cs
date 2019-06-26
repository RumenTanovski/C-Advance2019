using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Stat
    {
        public int Strength { get; set; }
        public int Flexibility { get; set; }
        public int Agility { get; set; }
        public int Skills { get; set; }
        public int Intelligence { get; set; }

        public Stat(int strenght, int flexibility, int agililty, int skills, int intelligance)
        {
            this.Strength = strenght;
            Flexibility = flexibility;
            Agility = agililty;
            Skills = skills;
            Intelligence = intelligance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        //        properties:
        //    • Strength: int
        //    • Ability: int
        //    • Intelligence: int
        //The class constructor should receive strength, ability and intelligence and override the ToString() method in the following format:
        //"Item:"
        //"  * Strength: {Strength Value}"
        //"  * Ability: {Ability Value}"
        //"  * Intelligence: {Intelligence Value}"

        public int Strength { get; set; }
        public int Ability { get; set; }
        public int Intelligence { get; set; }

        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public override string ToString()
        {
            string result = $"  * Strength: {Strength}"
                        +Environment.NewLine
                        + $"  * Ability: {Ability}"
                        + Environment.NewLine
                        + $"  * Intelligence: {Intelligence}";

            return result;
        }

    }
}

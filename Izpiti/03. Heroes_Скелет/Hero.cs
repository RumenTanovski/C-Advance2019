using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Hero
    {
        //    class Hero with the following properties:
        //• Name: string
        //• Level: int
        //• Item: Item
        //The class constructor should receive name, level and item and override the ToString() method in the following format:
        //"Hero: {Name} – {Level}lvl"
        //"Item:"
        //"  * Strength: {Strength Value}"
        //"  * Ability: {Ability Value}"
        //"  * Intelligence: {Intelligence Value}"

        public string Name { get; set; }
        public int Level { get; set; }
        public Item Item { get; set; }

        public Hero()
        {
        }

        public Hero(string name, int level, Item item):this()
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public override string ToString()
        {
            string result = $"Hero: {Name} – {Level}lvl"
        + Environment.NewLine
        + $"Item:"
        + Environment.NewLine
        + $"  * Strength: {Item.Strength}"
        + Environment.NewLine
        + $"  * Ability: {Item.Ability}"
        + Environment.NewLine
        + $"  * Intelligence: {Item.Intelligence}";

            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> listOfPokemon;

        public List<Pokemon> ListOfPokemon
        {
            get { return listOfPokemon; }
            set { listOfPokemon = value; }
        }

        public int NumberOfBadges
        {
            get { return numberOfBadges; }
            set { numberOfBadges = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Trainer()
        {
            numberOfBadges = 0;
            listOfPokemon = new List<Pokemon>();
        }

        public Trainer(string name):this()
        {
            this.Name = name;
        }

        public Trainer(string name, int numberOfBadges):this(name) 
        {
            this.NumberOfBadges = numberOfBadges;
        }

        public void AddPokemon(Pokemon pokemonName)
        {
            listOfPokemon.Add(pokemonName);
        }

    }
}

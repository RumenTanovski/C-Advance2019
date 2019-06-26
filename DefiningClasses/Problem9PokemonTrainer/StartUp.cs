using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // input data
            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Trainer> trainers = new List<Trainer>();

            while (line[0] != "Tournament")
            {
                string nameTrainer = line[0];
                string namePokemon = line[1];
                string pokemonElement = line[2];
                int pokemonHealth = int.Parse(line[3]);
                Pokemon currentPokemon = new Pokemon(namePokemon, pokemonElement, pokemonHealth);
                Trainer currentTrainer = new Trainer(nameTrainer);

                bool noAdd = true;
                foreach (var trainer in trainers)
                {
                    if (trainer.Name == nameTrainer)
                    {
                        trainer.AddPokemon(currentPokemon);
                        noAdd = false;
                    }                    
                }

                if (noAdd)
                {
                   currentTrainer.AddPokemon(currentPokemon);
                   trainers.Add(currentTrainer);
                }               
                    
                line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            //input command and work
            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var tren in trainers)
                {
                    bool isElement = false;
                    foreach (var pokem in tren.ListOfPokemon)
                    {
                        if (pokem.Element == command)
                        {
                            isElement = true;
                        }
                    }

                    if (isElement)
                    {
                        tren.NumberOfBadges += 1;
                    }
                    else
                    {
                        List<Pokemon> pokemonForRemove = new List<Pokemon>();
                        foreach (var pokem in tren.ListOfPokemon)
                        {
                            pokem.Health -= 10;
                            if (pokem.Health <= 0)
                            {
                                pokemonForRemove.Add(pokem);
                            }
                        }
                        foreach (var rem in pokemonForRemove)
                        {
                            tren.ListOfPokemon.Remove(rem);
                        }
                    }


                }
                command = Console.ReadLine();
            }

            List<Trainer> trainOrder = new List<Trainer>();
            trainOrder = trainers.OrderByDescending(x => x.NumberOfBadges)
                .ToList();

            foreach (var tren in trainOrder)
            {
                Console.WriteLine($"{tren.Name} {tren.NumberOfBadges} {tren.ListOfPokemon.Count}");
            }

        }
    }
}

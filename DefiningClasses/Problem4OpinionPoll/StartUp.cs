using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            People people = new People();
            
            for (int i = 0; i < peopleCount; i++)
            {
                string[] inputLine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = inputLine[0];
                int age = int.Parse(inputLine[1]);

                Person currentPerson = new Person(name, age);

                people.AddMember(currentPerson);
                //Console.WriteLine($"{currentPerson.Name} {currentPerson.Age}");
            }

            people.PrintOldest30Age();

        }
    }
}

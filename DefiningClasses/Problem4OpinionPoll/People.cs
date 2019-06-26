using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class People
    {
        private List<Person> spisak;

        public People()
        {
            this.spisak = new List<Person>();
        }

        public void AddMember(Person member)
        {
            spisak.Add(member);
        }

        public void PrintOldest30Age()
        {
            List<Person> olderPerson30 = spisak.OrderBy(s => s.Name)
                                                .ToList();
            foreach (var item in olderPerson30)
            {
                if (item.Age>30)
                {
                Console.WriteLine($"{item.Name} - {item.Age}");
                }
            }
        }
    }
}

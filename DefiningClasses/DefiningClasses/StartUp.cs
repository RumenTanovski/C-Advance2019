using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {   
            //Problem3
            int familiyMembersCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i <familiyMembersCount ; i++)
            {
                string[] memberData = Console.ReadLine()
                    .Split();
                string memberName = memberData[0];
                int memberAge = int.Parse(memberData[1]);

                Person member = new Person(memberName, memberAge);
                family.AddMember(member);                
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

        }
    }
}

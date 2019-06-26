using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            DateTime d2 = DateTime.Parse(Console.ReadLine());
            DateTime dBiger = d1 > d2 ? d1 : d2;
            DateTime dYoung = d1 < d2 ? d1 : d2;

            DateModifier dateModifier = new DateModifier();
           
             dateModifier.Diferance(dBiger, dYoung);

        }
    }
}

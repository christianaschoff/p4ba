using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Christian", "Aschoff", 41, 1250, "München");
            Person person2 = new Person("David", "Reher", 30, 1320.30, "Dortmund");
            Person person3 = new Person("Jörg", "Krampitz", 41, 1450.50, "Hannover");
            Writeblock(person1);
            Writeblock(person2);
            Writeblock(person3);
        }

        private static void Writeblock(Person pers)
        {
            Console.WriteLine("Name: " + pers.Nachname + "," + pers.Vorname
                              + "\t Alter:" + pers.Alter
                              + "\t Gehalt:" + pers.Gehalt.ToString("###,###.00") + "€"
                              + "\t Standort:" + pers.Standort);
        }
    }
}

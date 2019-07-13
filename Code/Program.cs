using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person1 = new Person("Christian", "Aschoff", 41, 1250, "München");
            IPerson person2 = new Person("David", "Reher", 30, 1320.30, "Dortmund");
            IPerson person3 = new Person("Jörg", "Krampitz", 41, 1450.50, "Hannover");
            Writeblock(person1);
            Writeblock(person2);
            Writeblock(person3);

            IGehalt personGehalt = new Person("Christian", "Aschoff", 41, 1250, "München");
            Console.WriteLine("Gehalt: " + personGehalt.Gehalt.ToString("###,###.00") + "€");

            IAlter personAlter = new Person("Christian", "Aschoff", 41, 1250, "München");
            Console.WriteLine("Alter: " + personAlter.Alter);

            INachname personNachname = new Person("Christian", "Aschoff", 41, 1250, "München");
            Console.WriteLine("Nachname: " + personNachname.Nachname);
        }

        private static void Writeblock(IPerson pers)
        {
            Console.WriteLine("Name: " + pers.Nachname + "," + pers.Vorname
                              + "\t Alter:" + pers.Alter
                              + "\t Gehalt:" + pers.Gehalt.ToString("###,###.00") + "€"
                              + "\t Standort:" + pers.Standort);
        }
    }
}

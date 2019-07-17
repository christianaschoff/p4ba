using System;
using Model;
using Contract;
using Rules;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            IKostenrechner kostenrechner = new Kostenrechner();
            IForecast forecast = new Forecast();

            IMitarbeiter mitarbeiter = new Mitarbeiter("Christian", "Aschoff", 41, 1250, "München", 7, ABTEILUNG.DEVELOPMENT, LEVEL.SENIOR);

            IProjekt projekt = new Projekt("super duper");
            projekt.Mitarbeiter.Add(mitarbeiter);

            string[] liste = new string[10];
            for(int i=0; i < liste.Length; i++) 
            {
                liste[i] = new String('A', i+1);
            }

            List<string> listeGeneric = new List<string>();
            for(int i = 0; i < 10; i++) 
            {
                listeGeneric.Add(new String('A', i+1));
            }
            
            foreach(string element in listeGeneric)
            {
                Console.WriteLine(element);
            }
        }
        
    }
}


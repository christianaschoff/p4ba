using System;
using Model;
using Contract;
using Rules;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            IProjekt projekt = GenerateProject("Super Duper Projekt");
            IProjektMetriken metriken = new ProjektMetriken(projekt);
            Console.WriteLine("Projektname: " + projekt.Name);
            Console.WriteLine("Anzahl Mitarbeiter: " + metriken.PersonenImProjekt());
            Console.WriteLine("Jahreskosten: " + metriken.PersonalkostenProJahr().ToString("0,000.00") + " €");

            List<double> quartalkosten = metriken.PersonalkostenQuartale(4);
            for (int i = 0; i < quartalkosten.Count; i++)
            {
                double quartal = quartalkosten[i];
                int quartalnummer = i + 1;
                Console.WriteLine("Kosten Quartal " + quartalnummer + ": " + quartal.ToString("0,000.00") + " €");
            }
        }
        static IProjekt GenerateProject(string name) 
        {
            IProjekt projekt = new Projekt(name);
            IMitarbeiter mitarbeiter = new Mitarbeiter("Christian", "Aschoff", 41, 1250, "München", 7, ABTEILUNG.DEVELOPMENT, LEVEL.SENIOR);
            IMitarbeiter mitarbeiter2 = new Mitarbeiter("Markus", "Allelein", 38, 1550, "", 1, ABTEILUNG.BUSINESS_ANALYTICS, LEVEL.SENIOR);
         
            IFreiberufler freiberufler = new Freiberufler("Sven", "Wendt", 41, 1350.50, "Hamburg", 980, PARTNERNETZ.SELBSTSTAENDIG);
            projekt.Mitarbeiter.Add(mitarbeiter);
            projekt.Mitarbeiter.Add(mitarbeiter2);
            projekt.Freiberufler.Add(freiberufler);

            return projekt;
        }

    }
}

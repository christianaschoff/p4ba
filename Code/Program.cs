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
            double gehalt = kostenrechner.BerechneJahresgehalt(mitarbeiter);
            
            Console.WriteLine(mitarbeiter.Vorname + " " + mitarbeiter.Nachname + " Grundgehalt: " + gehalt.ToString("#,###.00 €"));
            
            for(int i=1; i <= 5; i++) {
                gehalt = forecast.Gehaltsentwicklung(gehalt);
                 Console.WriteLine("Gehaltsentwicklung von " 
                                    + mitarbeiter.Vorname + " " 
                                    + mitarbeiter.Nachname + " " 
                                    + " im " + i + ". Jahr: "
                                    + gehalt.ToString("#,###.00 €"));
            }

            Auslastung auslastung = new Auslastung();
            for(int i = 210; i >= 0; i-=60)
            {
                Console.WriteLine("Auslastung ist bei " + i + " Tage(n) " + auslastung.BerechneAuslastungsstatus(i));
            }
           
        }
        
    }
}

using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            IMitarbeiter person1 = new Mitarbeiter(7,ABTEILUNG.DEVELOPMENT, LEVEL.SENIOR, "Christian", "Aschoff", 41, 1250, "München");
            IFreiberufler person2 = new Freiberufler(870, PARTNERNETZ.SELBSTSTAENDIG, "Sven", "Wendt", 41, 2340.80, "Hamburg");
            
            WriteblockMitarbeiter(person1);
            WriteblockFreiberufler(person2);       
        }

        private static void WriteblockMitarbeiter(IMitarbeiter mitarbeiter) 
        {
            Writeblock(mitarbeiter as IPerson);
            Console.WriteLine("\t Abteilung: " + mitarbeiter.Abteilung
                             + "\t\t Level: " + mitarbeiter.Level 
                             + "\t Betrieb: " + mitarbeiter.Betriebszugehoerigkeit);
        }

        private static void WriteblockFreiberufler(IFreiberufler freiberufler) 
        {
            Writeblock(freiberufler as IPerson);
            Console.WriteLine("\t Partnernetz: " + freiberufler.Partnernetz
                             + "\t Tagessatz: " + freiberufler.Tagessatz.ToString("###,###.00") + "€");
        }

        private static void Writeblock(IPerson pers)
        {
            Console.Write("Name: " + pers.Nachname + "," + pers.Vorname
                        + "\t Alter:" + pers.Alter
                        + "\t Gehalt:" + pers.Gehalt.ToString("###,###.00") + "€"
                        + "\t Standort:" + pers.Standort);
        }
    }
}

using System;
using Contract;

namespace Code
{
    public class ConsoleWriter
    {
        public void Write(IPerson pers)
        {
            WriteblockPerson(pers);
            if (pers is IMitarbeiter)
            {
                WriteblockMitarbeiter(pers as IMitarbeiter);
            }
            if (pers is IFreiberufler)
            {
                WriteblockFreiberufler(pers as IFreiberufler);
            }
        }

        private void WriteblockFreiberufler(IFreiberufler freiberufler)
        {
            Console.WriteLine("Name: " + freiberufler.Nachname + "," + freiberufler.Vorname
                              + "\t Alter:" + freiberufler.Alter
                              + "\t Gehalt:" + freiberufler.Gehalt.ToString("###,###.00") + "€"
                              + "\t Standort:" + freiberufler.Standort
                              + "\t Tagessatz:" + freiberufler.Tagessatz.ToString("###,###.00") + "€"
                              + "\t Partnernetz:" + freiberufler.Partnernetz);
        }

        private void WriteblockMitarbeiter(IMitarbeiter mitarbeiter)
        {
            Console.WriteLine("Name: " + mitarbeiter.Nachname + "," + mitarbeiter.Vorname
                              + "\t Alter:" + mitarbeiter.Alter
                              + "\t Gehalt:" + mitarbeiter.Gehalt.ToString("###,###.00") + "€"
                              + "\t Standort:" + mitarbeiter.Standort
                              + "\t Betriebszugehörigkeit:" + mitarbeiter.Betriebszugehoerigkeit
                              + "\t Abteilung:" + mitarbeiter.Abteilung
                              + "\t Level:" + mitarbeiter.Level);
        }

        private void WriteblockPerson(IPerson pers)
        {
            Console.WriteLine("Name: " + pers.Nachname + "," + pers.Vorname
                              + "\t Alter:" + pers.Alter
                              + "\t Gehalt:" + pers.Gehalt.ToString("###,###.00") + "€"
                              + "\t Standort:" + pers.Standort);
        }
    }
}

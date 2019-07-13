using System;

namespace Code
{
    public class Mitarbeiter : Person, IMitarbeiter
    {
        public int Betriebszugehoerigkeit { get; }
        public ABTEILUNG Abteilung { get; }
        public LEVEL Level { get; }

        public Mitarbeiter(int betriebszugehoerigkeit, ABTEILUNG abteilung, LEVEL level, string vorname, string nachname, int alter, double gehalt, string standort) 
        : base(vorname, nachname, alter, gehalt, standort)
        {
            this.Betriebszugehoerigkeit = betriebszugehoerigkeit;
            this.Abteilung = abteilung;
            this.Level = level;
        }
    }
}

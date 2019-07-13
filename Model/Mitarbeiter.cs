using System;
using Contract;

namespace Model
{
    public class Mitarbeiter : Person, IMitarbeiter
    {
        public int Betriebszugehoerigkeit { get; }

        public ABTEILUNG Abteilung { get; }

        public LEVEL Level { get; }

        public Mitarbeiter(string vorname, string nachname, int alter, double gehalt, string standort, int betriebszugehoerigkeit, ABTEILUNG abteilung, LEVEL level)
        : base(vorname, nachname, alter, gehalt, standort)
        {
            this.Betriebszugehoerigkeit = betriebszugehoerigkeit;
            this.Abteilung = abteilung;
            this.Level = level;
        }
    }
}

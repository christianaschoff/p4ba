
using Contract;

namespace Model
{
    public class Person : IPerson, IAlter, IGehalt, INachname
    {
        public string Vorname { get; }
        public string Nachname { get; }
        public int Alter { get; }
        public double Gehalt { get; }
        public string Standort { get; }

        public Person(string vorname, string nachname, int alter, double gehalt, string standort)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Alter = alter;
            this.Gehalt = gehalt;
            this.Standort = standort;
        }
    }
}

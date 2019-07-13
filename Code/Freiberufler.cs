using System;

namespace Code
{
    public class Freiberufler : Person, IFreiberufler
    {
        public double Tagessatz { get; }
        public PARTNERNETZ Partnernetz { get; }

        public Freiberufler(double tagessatz, PARTNERNETZ partnernetz, string vorname, string nachname, int alter, double gehalt, string standort) 
        : base(vorname, nachname, alter, gehalt, standort)
        {
            this.Tagessatz = tagessatz;
            this.Partnernetz = partnernetz;
        }
    }
}

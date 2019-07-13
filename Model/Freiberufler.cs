using Contract;

namespace Model
{
    public class Freiberufler : Person, IFreiberufler
    {
        public Freiberufler(string vorname, string nachname, int alter, double gehalt, string standort, double tagessatz, PARTNERNETZ partnernetz)
        : base(vorname, nachname, alter, gehalt, standort)
        {
            this.Tagessatz = tagessatz;
            this.Partnernetz = partnernetz;
        }
        public double Tagessatz { get; }

        public PARTNERNETZ Partnernetz { get; }

    }
}

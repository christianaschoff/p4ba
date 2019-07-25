using System;
using Contract;

namespace Rules
{
    public class Kostenrechner: IKostenrechner
    {
        public double BerechneJahresgehalt(IMitarbeiter mitarbeiter)
        {
            if(mitarbeiter.Gehalt == 0)
            {
                return 0;
            }

            if(mitarbeiter.Gehalt < 0)
            {
                throw new ArgumentOutOfRangeException("mitarbeiter.Gehalt", mitarbeiter.Gehalt, "Das Gehalt darf nicht negativ sein");
            }

            double jahresgehalt = mitarbeiter.Gehalt * 12;
            return jahresgehalt;
        }

        public double BerechneJahreskosten(IFreiberufler freiberufler)
        {
            double jahreskosten = freiberufler.Tagessatz * 220;
            return jahreskosten;
        }
    }
}

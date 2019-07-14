using System;
using Contract;

namespace Rules
{
    public class Kostenrechner: IKostenrechner
    {
        public double BerechneJahresgehalt(IMitarbeiter mitarbeiter)
        {
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

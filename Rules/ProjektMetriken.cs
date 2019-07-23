using System;
using System.Collections.Generic;
using Contract;
using Model;

namespace Rules
{
    public class ProjektMetriken : IProjektMetriken
    {
        private IProjekt projekt;
        IKostenrechner kostenrechner;
        public ProjektMetriken(IProjekt projekt)
        {
            this.projekt = projekt;
            this.kostenrechner = new Kostenrechner();
        }

        public int PersonenImProjekt()
        {
            return this.projekt.Freiberufler.Count + this.projekt.Mitarbeiter.Count;
        }

        public double PersonalkostenProJahr()
        {
            double personalkosten = 0.0;
            foreach (IFreiberufler freiberufler in this.projekt.Freiberufler)
            {
                personalkosten += kostenrechner.BerechneJahreskosten(freiberufler);
            }
            foreach (IMitarbeiter mitarbeiter in this.projekt.Mitarbeiter)
            {
                personalkosten += kostenrechner.BerechneJahresgehalt(mitarbeiter);
            }
            return personalkosten;
        }

        public List<double> PersonalkostenQuartale(int anzahlQuartale)
        {
            List<double> quartale = new List<double>();
            double personalkostenJeQuartal = PersonalkostenProJahr() / 4;
            for (int i = 1; i <= anzahlQuartale; i++)
            {
                quartale.Add(personalkostenJeQuartal);
            }
            return quartale;
        }
    }
}

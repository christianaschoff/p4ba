using System;
using System.Collections.Generic;

namespace Contract
{
    public interface IProjektMetriken
    {
         double PersonalkostenProJahr();
        List<double> PersonalkostenQuartale(int anzahlQuartale);
        int PersonenImProjekt();
    }
}

using System;

namespace Contract
{
    public interface IAuslastung
    {
        AUSLASTUNG BerechneAuslastungsstatus(int tageProJahr);
    }
}

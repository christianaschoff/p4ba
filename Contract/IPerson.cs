using System;

namespace Contract
{
    public interface IPerson
    {
        string Vorname { get; }
        string Nachname { get; }
        int Alter { get; }
        double Gehalt { get; }
        string Standort { get; }
    }
}

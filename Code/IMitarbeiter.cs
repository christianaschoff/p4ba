namespace Code
{
    internal interface IMitarbeiter: IPerson
    {
        int Betriebszugehoerigkeit { get; }
        ABTEILUNG Abteilung { get; }
        LEVEL Level { get; }
    }
}
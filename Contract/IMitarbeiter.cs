namespace Contract
{
    public interface IMitarbeiter : IPerson
    {
        int Betriebszugehoerigkeit { get; }
        ABTEILUNG Abteilung { get; }
        LEVEL Level { get; }
    }
}
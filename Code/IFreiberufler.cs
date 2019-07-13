namespace Code
{
    internal interface IFreiberufler : IPerson
    {
        double Tagessatz { get; }
        PARTNERNETZ Partnernetz { get; }
    }
}
namespace Contract
{
    public interface IFreiberufler : IPerson
    {
        double Tagessatz { get; }
        PARTNERNETZ Partnernetz { get; }
    }
}
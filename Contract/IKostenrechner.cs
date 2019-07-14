namespace Contract 
{
    public interface IKostenrechner
    {
        double BerechneJahresgehalt(IMitarbeiter mitarbeiter);
        double BerechneJahreskosten(IFreiberufler freiberufler);
    }
}
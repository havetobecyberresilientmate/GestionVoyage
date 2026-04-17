abstract class Voyage
{
    protected string _destination;
    protected DateTime _dateDepart;
    protected double _prix;

    public Voyage(string destination, DateTime dateDepart, double prix)
    {
        _destination = destination;
        _dateDepart = dateDepart;
        _prix = prix;
    }

    public abstract void AfficherDetails();
}

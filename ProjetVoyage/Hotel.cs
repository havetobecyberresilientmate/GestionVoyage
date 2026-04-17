class Hotel : Voyage
{
    private string _nomHotel;
    private int _nombreNuits;

    public Hotel(string destination, DateTime dateDepart, double prix, string nomHotel, int nombreNuits)
        : base(destination, dateDepart, prix)
    {
        _nomHotel = nomHotel;
        _nombreNuits = nombreNuits;
    }

    public override void AfficherDetails()
    {
        throw new NotImplementedException();
    }
}

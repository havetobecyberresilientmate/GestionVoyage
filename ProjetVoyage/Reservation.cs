class Reservation
{
    private DateTime _dateReservation;
    private string _statut;
    private Client _client;
    private Voyage _voyage;

    public Reservation(DateTime dateReservation, string statut, Client client, Voyage voyage)
    {
        _dateReservation = dateReservation;
        _statut = statut;
        _client = client;
        _voyage = voyage;
    }

    public void Confirmer()
    {
        throw new NotImplementedException();
    }

    public void Annuler()
    {
        throw new NotImplementedException();
    }
}

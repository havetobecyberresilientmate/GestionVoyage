class Paiement
{
    private double _montant;
    private DateTime _date;
    private Reservation _reservation;

    public Paiement(double montant, DateTime date, Reservation reservation)
    {
        _montant = montant;
        _date = date;
        _reservation = reservation;
    }

    public void EffectuerPaiement()
    {
        throw new NotImplementedException();
    }
}

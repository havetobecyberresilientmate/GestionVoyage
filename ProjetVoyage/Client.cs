class Client
{
    private string _nom;
    private string _prenom;
    private string _email;
    private string _telephone;

    public Client(string nom, string prenom, string email, string telephone)
    {
        _nom = nom;
        _prenom = prenom;
        _email = email;
        _telephone = telephone;
    }

    public void Reserver()
    {
        throw new NotImplementedException();
    }

    public void Annuler()
    {
        throw new NotImplementedException();
    }
}

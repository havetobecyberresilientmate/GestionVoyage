class Vol : Voyage
{
    private string _numeroVol;
    private string _compagnie;

    public Vol(string destination, DateTime dateDepart, double prix, string numeroVol, string compagnie)
        : base(destination, dateDepart, prix)
    {
        _numeroVol = numeroVol;
        _compagnie = compagnie;
    }

    public override void AfficherDetails()
    {
        throw new NotImplementedException();
    }
}

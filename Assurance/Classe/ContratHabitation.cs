public class ContratHabitation : Contrat
{
    public ContratHabitation()
    {
        ClausesStandard = "Clauses standard assurance habitation";
    }

    public override Contrat Clone()
    {
        var copie = (ContratHabitation)this.MemberwiseClone();
        copie.Annexes = new List<string>(Annexes);
        return copie;
    }
}

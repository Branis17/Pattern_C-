public class ContratVie : Contrat
{
    public ContratVie()
    {
        ClausesStandard = "Clauses standard assurance vie";
    }

    public override Contrat Clone()
    {
        var copie = (ContratVie)this.MemberwiseClone();
        copie.Annexes = new List<string>(Annexes);
        return copie;
    }
}

public class ContratAuto : Contrat
{
    public ContratAuto()
    {
        ClausesStandard = "Clauses standard assurance automobile";
    }

    public override Contrat Clone()
    {
        var copie = (ContratAuto)this.MemberwiseClone();
        copie.Annexes = new List<string>(Annexes);
        return copie;
    }
}

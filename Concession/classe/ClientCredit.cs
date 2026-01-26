public class ClientCredit : Client
{
    public override Commande CreeCommande(double montant)
    {
        return new CommandeCredit(montant);
    }
}

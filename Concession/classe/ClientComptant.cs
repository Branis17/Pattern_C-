public class ClientComptant : Client
{
    public override Commande CreeCommande(double montant)
    {
        return new CommandeComptant(montant);
    }
}

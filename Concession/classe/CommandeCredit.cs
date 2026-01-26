using System;

public class CommandeCredit : Commande
{
    public CommandeCredit(double montant)
    {
        this.montant = montant;
    }

    public override void Executer()
    {
        Console.WriteLine($"Commande à crédit : paiement de {montant} € à crédit");
    }
}

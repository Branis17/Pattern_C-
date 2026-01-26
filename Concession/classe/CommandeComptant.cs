using System;

public class CommandeComptant : Commande
{
    public CommandeComptant(double montant)
    {
        this.montant = montant;
    }

    public override void Executer()
    {
        Console.WriteLine($"Commande au comptant : paiement de {montant} €");
    }
}

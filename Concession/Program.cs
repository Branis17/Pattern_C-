using System;

class Program
{
    /*static void Main()
    {
        var liasseVierge = LiasseVierge.Instance;
        var liasseClient = liasseVierge.Clone();

        liasseClient.Imprimer();
    }excercie 1 */
  


 static void Main()
    {
        // Client au comptant
        Client clientComptant = new ClientComptant();
        Commande commande1 = clientComptant.CreeCommande(15000);
        commande1.Executer();

        // Client à crédit
        Client clientCredit = new ClientCredit();
        Commande commande2 = clientCredit.CreeCommande(22000);
        commande2.Executer();
    }


}

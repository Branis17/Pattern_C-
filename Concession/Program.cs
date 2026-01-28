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
        
        Client clientComptant = new ClientComptant();
        Commande commande1 = clientComptant.CreeCommande(1500);
        commande1.Executer();

       
        Client clientCredit = new ClientCredit();
        Commande commande2 = clientCredit.CreeCommande(0);
        commande2.Executer();
    }


}

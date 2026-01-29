public class InventoryService
{
    public InventoryService()
    {
        // Simulation d'une initialisation coûteuse
        Console.WriteLine("InventoryService: Connexion à la base de données...");
        Thread.Sleep(1000); // Simulation délai
        Console.WriteLine("InventoryService: Prêt");
    }

    public bool CheckStock(string productId, int quantity)
    {
        Console.WriteLine($"InventoryService: Vérification stock pour {productId}");
        return true;
    }

    public void ReserveStock(string productId, int quantity)
    {
        Console.WriteLine($"InventoryService: Réservation de {quantity} x {productId}");
    }
}
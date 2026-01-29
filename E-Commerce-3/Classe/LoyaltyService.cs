public class LoyaltyService
{
    public void AddPoints(string customerId, int points)
    {
        Console.WriteLine($"LoyaltyService: +{points} points pour {customerId}");
    }

    public int GetPoints(string customerId)
    {
        return 150; // Simulation
    }
}
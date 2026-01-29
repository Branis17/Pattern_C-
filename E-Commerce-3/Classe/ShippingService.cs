public class ShippingService
{
    public string CreateShipment(string orderId, string address)
    {
        Console.WriteLine($"ShippingService: Création expédition pour commande {orderId}");
        return "TRACK-" + Guid.NewGuid().ToString().Substring(0, 8);
    }
}

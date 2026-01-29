public class OrderFacade
{
    private IInventoryService inventory;
    private IPaymentService payment;
    private ShippingService shipping;
    private NotificationService notification;
    private LoyaltyService loyalty;

    public OrderFacade(IInventoryService inventory, IPaymentService payment)
    {
        this.inventory = inventory;
        this.payment = payment;
        shipping = new ShippingService();
        notification = new NotificationService();
        loyalty = new LoyaltyService();
    }

    public void PlaceOrder(string productId, string customerId, decimal amount)
    {
        if (!inventory.CheckStock(productId, 1)) return;

        inventory.ReserveStock(productId, 1);

        if (!payment.ProcessPayment(customerId, amount)) return;

        string orderId = Guid.NewGuid().ToString();
        string tracking = shipping.CreateShipment(orderId, "Adresse client");

        notification.SendEmail("client@mail.com", "Commande OK", tracking);
        loyalty.AddPoints(customerId, (int)(amount * 10));

        Console.WriteLine("Commande terminée avec succès");
    }
}

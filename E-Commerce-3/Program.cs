class Program
{
    static void Main()
    {
        IInventoryService inventory = new InventoryServiceProxy();
        IPaymentService payment = new PaymentServiceProxy(isVIP: false);

        OrderFacade facade = new OrderFacade(inventory, payment);

        facade.PlaceOrder("PROD-001", "CUST-123", 99.99m);
    }
}

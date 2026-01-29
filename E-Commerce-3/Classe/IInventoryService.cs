public interface IInventoryService
{
    bool CheckStock(string productId, int quantity);
    void ReserveStock(string productId, int quantity);
}

public interface IPaymentService
{
    bool ProcessPayment(string customerId, decimal amount);
}

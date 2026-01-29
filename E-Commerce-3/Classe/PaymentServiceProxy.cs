public class PaymentServiceProxy : IPaymentService
{
    private PaymentService realService;
    private bool isVIP;

    public PaymentServiceProxy(bool isVIP)
    {
        this.isVIP = isVIP;
    }

    public bool ProcessPayment(string customerId, decimal amount)
    {
        if (!isVIP && amount > 100)
        {
            Console.WriteLine("Paiement refusé : client non VIP");
            return false;
        }

        realService ??= new PaymentService();
        return realService.ProcessPayment(customerId, amount);
    }
}

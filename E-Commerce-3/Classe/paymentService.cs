public class PaymentService
{
    public PaymentService()
    {
        Console.WriteLine("PaymentService: Établissement connexion sécurisée...");
        Thread.Sleep(500);
        Console.WriteLine("PaymentService: Prêt");
    }

    public bool ProcessPayment(string customerId, decimal amount)
    {
        Console.WriteLine($"PaymentService: Traitement paiement de {amount}€ pour {customerId}");
        return true;
    }

    public void RefundPayment(string transactionId)
    {
        Console.WriteLine($"PaymentService: Remboursement {transactionId}");
    }
}
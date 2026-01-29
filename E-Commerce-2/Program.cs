class Program
{
    static void ProcessOrder(IPaymentService paymentService, decimal total)
    {
        bool success = paymentService.ProcessPayment(total, "EUR");
        if (success)
        {
            Console.WriteLine("Commande traitée avec succès");
        }
    }

    static void Main(string[] args)
    {
        IPaymentService service = new InternalPaymentService();
        ProcessOrder(service, 99.99m);

        // TODO: Comment utiliser PaymentPro ici sans modifier ProcessOrder ?
        // PaymentPro paymentPro = new PaymentPro();
        // ProcessOrder(paymentPro, 149.99m); // Erreur de compilation !
    }
}

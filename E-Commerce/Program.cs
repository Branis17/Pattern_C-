class Program
{
    static void Main()
    {
        CanalNotification email = new CanalEmail();
        CanalNotification sms = new CanalSMS();
        CanalNotification push = new CanalPush();

        Notification commande = new NotificationCommande(email);
        commande.Envoyer("Votre commande est confirmée");

        Notification livraison = new NotificationLivraison(sms);
        livraison.Envoyer("Votre colis est en route");

        Notification support = new NotificationSupport(push);
        support.Envoyer("Un agent va vous contacter");
    }
}

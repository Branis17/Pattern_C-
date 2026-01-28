public class NotificationCommande : Notification
{
    public NotificationCommande(CanalNotification canal) : base(canal) {}

    public override void Envoyer(string message)
    {
        canal.Envoyer("Commande", message);
    }
}

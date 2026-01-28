public class NotificationLivraison : Notification
{
    public NotificationLivraison(CanalNotification canal) : base(canal) {}

    public override void Envoyer(string message)
    {
        canal.Envoyer("Livraison", message);
    }
}

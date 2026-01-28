public class NotificationSupport : Notification
{
    public NotificationSupport(CanalNotification canal) : base(canal) {}

    public override void Envoyer(string message)
    {
        canal.Envoyer("Support", message);
    }
}

public abstract class Notification
{
    protected CanalNotification canal;

    protected Notification(CanalNotification canal)
    {
        this.canal = canal;
    }

    public abstract void Envoyer(string message);
}

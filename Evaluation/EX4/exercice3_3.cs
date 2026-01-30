//EX4.3
public interface INotificationStrategy
{
    void Send(string recipient, string message);
}

public class EmailNotification : INotificationStrategy
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"Email à {recipient}: {message}");
    }
}

public class SmsNotification : INotificationStrategy
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"SMS à {recipient}: {message}");
    }
}

public class NotificationService
{
    private INotificationStrategy strategy;

    public NotificationService(INotificationStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void Notify(string recipient, string message)
    {
        strategy.Send(recipient, message);
    }
}




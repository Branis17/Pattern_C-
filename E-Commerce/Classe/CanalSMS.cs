using System;

public class CanalSMS : CanalNotification
{
    public void Envoyer(string typeNotification, string message)
    {
        Console.WriteLine($"SMS - {typeNotification} : {message}");
    }
}

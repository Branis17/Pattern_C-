using System;

public class CanalPush : CanalNotification
{
    public void Envoyer(string typeNotification, string message)
    {
        Console.WriteLine($"Push - {typeNotification} : {message}");
    }
}

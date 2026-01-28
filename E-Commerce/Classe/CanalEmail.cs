using System;

public class CanalEmail : CanalNotification
{
    public void Envoyer(string typeNotification, string message)
    {
        Console.WriteLine($"Email - {typeNotification} : {message}");
    }
}

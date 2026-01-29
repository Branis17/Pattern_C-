using System;

public class LoggingDecorator : MessageDecorator
{
    public LoggingDecorator(IMessage message) : base(message) {}

    public override string Process()
    {
        string result = message.Process();
        Console.WriteLine($"[LOG] Message traité : {result}");
        return result;
    }
}


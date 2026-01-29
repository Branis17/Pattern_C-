public class SignatureDecorator : MessageDecorator
{
    public SignatureDecorator(IMessage message) : base(message) {}

    public override string Process()
    {
        return $"[SIGNED: {message.Process()}]";
    }
}

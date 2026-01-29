public class EncryptionDecorator : MessageDecorator
{
    public EncryptionDecorator(IMessage message) : base(message) {}

    public override string Process()
    {
        return $"[ENCRYPTED: {message.Process()}]";
    }
}

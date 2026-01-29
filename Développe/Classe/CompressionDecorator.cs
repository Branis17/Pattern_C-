public class CompressionDecorator : MessageDecorator
{
    public CompressionDecorator(IMessage message) : base(message) {}

    public override string Process()
    {
        return $"[COMPRESSED: {message.Process()}]";
    }
}

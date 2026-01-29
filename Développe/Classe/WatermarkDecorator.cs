public class WatermarkDecorator : MessageDecorator
{
    public WatermarkDecorator(IMessage message) : base(message) {}

    public override string Process()
    {
        return $"[WATERMARKED: {message.Process()}]";
    }
}

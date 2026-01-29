public abstract class MessageDecorator : IMessage
{
    protected IMessage message;

    protected MessageDecorator(IMessage message)
    {
        this.message = message;
    }

    public abstract string Process();
}

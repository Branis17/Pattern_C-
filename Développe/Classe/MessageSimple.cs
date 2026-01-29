public class MessageSimple : IMessage
{
    private readonly string content;

    public MessageSimple(string content)
    {
        this.content = content;
    }

    public string Process()
    {
        return content;
    }
}

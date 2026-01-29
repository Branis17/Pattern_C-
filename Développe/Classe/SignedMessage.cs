public class SignedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[SIGNED: {Content}]";
    }
}
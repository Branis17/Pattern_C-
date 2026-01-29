public class CompressedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[COMPRESSED: {Content}]";
    }
}

public class CompressedAndSignedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[SIGNED: [COMPRESSED: {Content}]]";
    }
}
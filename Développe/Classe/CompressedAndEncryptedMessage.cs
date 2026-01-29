public class CompressedAndEncryptedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[ENCRYPTED: [COMPRESSED: {Content}]]";
    }
}
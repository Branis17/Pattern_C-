public class EncryptedMessage
{
    public string Content { get; set; }

    public string Process()
    {
        return $"[ENCRYPTED: {Content}]";
    }
}

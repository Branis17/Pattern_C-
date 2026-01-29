class Program
{
    static void Main()
    {
        // Message simple
        IMessage msg1 = new MessageSimple("Hello World");
        Console.WriteLine(msg1.Process());

        Console.WriteLine();

        // Compression + Chiffrement
        IMessage msg2 =
            new EncryptionDecorator(
                new CompressionDecorator(
                    new MessageSimple("Secret data")
                )
            );

        Console.WriteLine(msg2.Process());

        Console.WriteLine();

        // Chiffrement + Signature + Logging
        IMessage msg3 =
            new LoggingDecorator(
                new SignatureDecorator(
                    new EncryptionDecorator(
                        new MessageSimple("Very confidential")
                    )
                )
            );

        Console.WriteLine(msg3.Process());
    }
}

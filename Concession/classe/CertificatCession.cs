using System;

public class CertificatCession : Document
{
    public override void Imprimer()
    {
        Console.WriteLine("Certificat de cession vierge");
    }

    public override Document Clone()
    {
        return (Document)this.MemberwiseClone();
    }
}

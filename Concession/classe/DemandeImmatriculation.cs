using System;

public class DemandeImmatriculation : Document
{
    public override void Imprimer()
    {
        Console.WriteLine("Demande d'immatriculation vierge");
    }

    public override Document Clone()
    {
        return (Document)this.MemberwiseClone();
    }
}

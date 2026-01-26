using System;

public class BonCommande : Document
{
    public override void Imprimer()
    {
        Console.WriteLine("Bon de commande vierge");
    }

    public override Document Clone()
    {
        return (Document)this.MemberwiseClone();
    }
}

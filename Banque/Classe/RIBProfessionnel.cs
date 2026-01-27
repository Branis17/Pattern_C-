using System;

public class RIBProfessionnel : RIB
{
    public override void Generer()
    {
        Console.WriteLine($"{logo} - RIB détaillé avec SIRET (Professionnel)");
    }
}

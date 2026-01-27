using System;

public class AttestationProfessionnel : Attestation
{
    public override void Generer()
    {
        Console.WriteLine($"{logo} - Attestation avec mentions légales (Professionnel)");
    }
}

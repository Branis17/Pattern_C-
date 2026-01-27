using System;

public class AttestationParticulier : Attestation
{
    public override void Generer()
    {
        Console.WriteLine($"{logo} - Attestation de compte standardisée (Particulier)");
    }
}

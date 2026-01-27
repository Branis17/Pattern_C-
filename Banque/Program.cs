using System;

class Program
{
    static void Main()
    {
        FabriqueDocumentsBancaires fabrique;

        // Client particulier
        fabrique = new FabriqueParticulier();
        fabrique.CreerRIB().Generer();
        fabrique.CreerAttestation().Generer();

        Console.WriteLine();

        // Client professionnel
        fabrique = new FabriqueProfessionnel();
        fabrique.CreerRIB().Generer();
        fabrique.CreerAttestation().Generer();
    }
}

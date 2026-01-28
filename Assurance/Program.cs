using System;

class Program
{
    static void Main()
    {
        // Création du contrat de base (prototype)
        Contrat contratBase = new ContratHabitation
        {
            NomClient = "Prototype",
            DateDebut = DateTime.Today,
            DateFin = DateTime.Today.AddYears(1),
            Montant = 500
        };

        contratBase.Annexes.Add("Annexe incendie");

        // Copie et personnalisation
        Contrat contratClient1 = contratBase.Clone();
        contratClient1.NomClient = "Alice Dupont";
        contratClient1.Montant = 550;

        Contrat contratClient2 = contratBase.Clone();
        contratClient2.NomClient = "Bob Martin";
        contratClient2.Montant = 600;
        contratClient2.Annexes.Add("Option vol");

        contratClient1.Afficher();
        contratClient2.Afficher();
    }
}

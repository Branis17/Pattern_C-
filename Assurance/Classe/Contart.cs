using System;
using System.Collections.Generic;

public abstract class Contrat
{
    public string NomClient { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public double Montant { get; set; }
    public List<string> Annexes { get; set; } = new();

    protected string ClausesStandard;

    public abstract Contrat Clone();

    public virtual void Afficher()
    {
        Console.WriteLine($"Client : {NomClient}");
        Console.WriteLine($"Période : {DateDebut:d} - {DateFin:d}");
        Console.WriteLine($"Montant : {Montant} €");
        Console.WriteLine($"Clauses : {ClausesStandard}");
        Console.WriteLine("Annexes : " + string.Join(", ", Annexes));
        Console.WriteLine("--------------------------------");
    }
}

using System.Collections.Generic;

public class Liasse
{
    protected List<Document> documents = new List<Document>();

    public void Ajouter(Document document)
    {
        documents.Add(document);
    }

    public void Imprimer()
    {
        foreach (var doc in documents)
        {
            doc.Imprimer();
        }
    }

    public Liasse Clone()
    {
        Liasse copie = new Liasse();
        foreach (var doc in documents)
        {
            copie.Ajouter(doc.Clone());
        }
        return copie;
    }
}

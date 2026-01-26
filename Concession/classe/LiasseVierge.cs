public class LiasseVierge : Liasse
{
    private static LiasseVierge instance;

    private LiasseVierge()
    {
        Ajouter(new CertificatCession());
        Ajouter(new DemandeImmatriculation());
        Ajouter(new BonCommande());
    }

    public static LiasseVierge Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new LiasseVierge();
            }
            return instance;
        }
    }
}

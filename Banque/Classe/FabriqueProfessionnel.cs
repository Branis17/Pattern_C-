public class FabriqueProfessionnel : FabriqueDocumentsBancaires
{
    public RIB CreerRIB()
    {
        return new RIBProfessionnel();
    }

    public Attestation CreerAttestation()
    {
        return new AttestationProfessionnel();
    }
}

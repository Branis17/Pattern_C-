public class FabriqueParticulier : FabriqueDocumentsBancaires
{
    public RIB CreerRIB()
    {
        return new RIBParticulier();
    }

    public Attestation CreerAttestation()
    {
        return new AttestationParticulier();
    }
}

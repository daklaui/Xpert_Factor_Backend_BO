namespace CleanArc.Domain.DTO;

public class GetAllBordDTO
{
    public string NUM_BORD { get; set; }
    public int REF_CTR_BORD { get; set; }
    public short? NB_DOC_BORD { get; set; }
    public string ANNEE_BORD { get; set; }
    public DateTime? DAT_SAISIE_BORD { get; set; }
    public int Nbre_Det { get; set; }
    public string Nom_ADH { get; set; }
    public decimal MontantTotale { get; set; }
    public int REF_CTR_PAPIER_CTR { get; set; }
}
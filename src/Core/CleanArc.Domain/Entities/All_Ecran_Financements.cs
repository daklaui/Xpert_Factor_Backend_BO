namespace CleanArc.Domain.Entities;

public class All_Ecran_Financements
{
    public int Id { get; set; }
    public decimal Encours_Facture { get; set; }
    public decimal Toatl_FDG { get; set; }
    public decimal Total_Avoir { get; set; }
    public decimal Total_Commission { get; set; }
    public decimal Total_Credit { get; set; }
    public decimal Total_Debit { get; set; }
    public decimal Total_Retenue { get; set; }
    public decimal Total_Facture { get; set; }
    public decimal Total_Financement { get; set; }
    public decimal Total_Interet { get; set; }
    public decimal Total_IR_All_annee { get; set; }
    public int REF_CTR { get; set; }
}
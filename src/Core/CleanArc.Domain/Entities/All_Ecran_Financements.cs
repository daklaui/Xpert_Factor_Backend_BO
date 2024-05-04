using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.Entities;
[Keyless]
public class All_Ecran_Financements
{

    public int REF_CTR { get; set; }
    public int REF_IND { get; set; }
    public string NOM_IND { get; set; }
    public Nullable<decimal> Total_Facture { get; set; }
    public Nullable<decimal> Encours_Facture { get; set; }
    public Nullable<decimal> Total_Financement { get; set; }
    public Nullable<decimal> Total_Financement_En_ATTente { get; set; }
    public Nullable<decimal> TEG { get; set; }
    public Nullable<decimal> Tx_Couverture { get; set; }
    public Nullable<decimal> Total_Litiges_echus { get; set; }
    public Nullable<decimal> Total_Avoir { get; set; }
    public Nullable<decimal> Total_Commission { get; set; }

    public Nullable<decimal> Total_Debit { get; set; }
    public Nullable<decimal> Total_Credit { get; set; }
    public Nullable<decimal> Total_Interet { get; set; }
    public Nullable<decimal> Depass_Limite { get; set; }
    public Nullable<decimal> Total_Retenue { get; set; }
    public Nullable<decimal> Toatl_FDG { get; set; }
    public Nullable<decimal> Total_IR_annee { get; set; }
    public Nullable<decimal> Total_IR_All_annee { get; set; }
    public Nullable<decimal> Disponible { get; set; }
}
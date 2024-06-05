using Microsoft.EntityFrameworkCore;

namespace CleanArc.Domain.StoredProcuderModel;
[Keyless]
public class SelectRefEncaissementParCtrETAch_Result
{
    public Nullable<System.DateTime> DAT_RECEP_ENC { get; set; }
    public Nullable<System.DateTime> DAT_VAL_ENC { get; set; }
    public string DEVISE_ENC { get; set; }
    public short ID_ENC { get; set; }
    public Nullable<decimal> MONT_ENC { get; set; }
    public Nullable<int> REF_ACH_ENC { get; set; }
    public Nullable<int> REF_ADH_ENC { get; set; }
    public int REF_CTR_ENC { get; set; }
    public string REF_ENC { get; set; }
    public string REF_SEQ_ENC { get; set; }
    public string RIB_ENC { get; set; }
    public string TYP_ENC { get; set; }
    public Nullable<bool> VALIDE_ENC { get; set; }
    public string Expr1 { get; set; }

}
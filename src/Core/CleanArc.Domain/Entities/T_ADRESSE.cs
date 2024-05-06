
namespace CleanArc.Domain.Entities;

public partial class T_ADRESSE
{
    public short ID_ADR { get; set; }

    public int REF_IND_ADR { get; set; }

    public string LIB_ADR { get; set; }

    public string CP_ADR { get; set; }

    public short? ID_LOC_ADR { get; set; }

    public short? ID_DELEG_ADR { get; set; }

    public short? ID_GOUV_ADR { get; set; }

    public short? ID_NLDP { get; set; }

    public bool? ACTIF_ADR { get; set; }

    public virtual T_INDIVIDU REF_IND_ADRNavigation { get; set; }
}

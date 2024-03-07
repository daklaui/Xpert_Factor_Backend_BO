using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.Individu.Queries.GetByIdQuery;

public record GetByIdQueryResult : ICreateMapper<T_INDIVIDU>
{
    public int REF_IND { get; set; }

    public string GENRE_IND { get; set; }

    public string TYP_DOC_ID_IND { get; set; }

    public string NUM_DOC_ID_IND { get; set; }

    public string LIEU_DOC_ID_IND { get; set; }

    public DateTime? DATE_DOC_ID_IND { get; set; }

    public string COD_TVA_IND { get; set; }

    public string NOM_IND { get; set; }

    public string PRE_IND { get; set; }

    public DateTime? DAT_NAISS_CREAT { get; set; }

    public bool? GRP_IND { get; set; }

    public decimal? LIM_CRED_GLO_IND { get; set; }

    public decimal? LIM_FIN_GLO_IND { get; set; }

    public string INFO_IND { get; set; }

    public DateTime? DAT_INFO_IND { get; set; }

    public int? ID_NLDP { get; set; }

    public string COD_SCLAS { get; set; }

    public string ABRV_IND { get; set; }


    public string MF_IND { get; set; }

    public string RC_IND { get; set; }

    public bool? EXO_TVA { get; set; }

    public DateTime? DAT_DEB_EXO { get; set; }

    public DateTime? DAT_FIN_EXO { get; set; }

    public string TEL_IND { get; set; }

    public string FAX_IND { get; set; }

    public string EMAIL_IND { get; set; }

    public string REF_ADH_IND { get; set; }

    public string FROM_JUR_IND { get; set; }

    public bool? EXO_IND { get; set; }

    public string ADR_IND { get; set; }

    public string CP_IND { get; set; }

    public string REF_ACH_IND { get; set; }

    public int? ID_GROUPE { get; set; }

    public virtual ICollection<TJ_CIR> TJ_CIRs { get; } = new List<TJ_CIR>();

    public virtual ICollection<T_ADRESSE> T_ADRESSEs { get; } = new List<T_ADRESSE>();
}
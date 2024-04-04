using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.TDetBord.Queries.GetById;

public record GetByIdQueryResult : ICreateMapper<T_DET_BORD>
{
    public string ID_DET_BORD { get; set; }

    public int REF_CTR_DET_BORD { get; set; }

    public string ANNEE_BORD { get; set; }

    public string NUM_BORD { get; set; }

    public string TYP_DET_BORD { get; set; }

    public string NUM_CREANCE_ASS_BORD { get; set; }

    public string TYP_ASS_DET_BORD { get; set; }

    public DateTime? DAT_DET_BORD { get; set; }

    public decimal? MONT_TTC_DET_BORD { get; set; }

    public string DEVISE_DET_BORD { get; set; }

    public short? ECH_DET_BORD { get; set; }

    public DateTime? ECH_APR_PROROG_DET_BORD { get; set; }

    public decimal? MONT_OUV_DET_BORD { get; set; }

    public short? DELAI_PAIE_DET_BORD { get; set; }

    public string MODE_REG_DET_BORD { get; set; }

    public string TYP_REG_DET_BORD { get; set; }

    public decimal? TX_FDG_DET_BORD { get; set; }

    public decimal? TX_COMM_FACT_DET_BORD { get; set; }

    public bool? ANNUL_DET_BORD { get; set; }

    public bool? VALIDE_DET_BORD { get; set; }

    public int? REF_IND_DET_BORD { get; set; }

    public decimal? MONT_FDG_DET_BORD { get; set; }

    public decimal? MONT_FDG_LIBERE_DET_BORD { get; set; }

    public decimal? MONT_COMM_FACT_DET_BORD { get; set; }

    public decimal? TX_TVA_COMM_FACT_DET_BORD { get; set; }

    public decimal? MONT_TVA_COMM_FACT_DET_BORD { get; set; }

    public decimal? MONT_TTC_COMM_FACT_DET_BORD { get; set; }

    public int? ID_CALC_DISPO_DET_BORD { get; set; }

    public string REF_DET_BORD { get; set; }

    public string COMM_DET_BORD { get; set; }

    public decimal? RETENU_DET_BORD { get; set; }

    public virtual T_CONTRAT REF_CTR_DET_BORDNavigation { get; set; }
}
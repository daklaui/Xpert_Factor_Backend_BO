using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.Limite.Queries.GetListOfDemLimit;

public class GetListOfDemLimitQueryResult: ICreateMapper<T_DEM_LIMITE>
{
    public int REF_DEM_LIM { get; set; }

    public int REF_CTR_DEM_LIM { get; set; }

    public string TYP_DEM_LIM { get; set; }

    public DateTime DAT_DEM_LIM { get; set; }

    public string SORT_DEM_LIM { get; set; }

    public decimal? MONT_DEM_LIM { get; set; }

    public string DEVISE { get; set; }

    public DateTime? DAT_LAST_DEM_LIM { get; set; }

    public string DECISION_LIM { get; set; }

    public decimal? MONT_ACC { get; set; }

    public decimal? MONT_LIM_ACH_ADH { get; set; }

    public DateTime? DAT_ANNUL_DEM_LIM { get; set; }

    public DateTime? DATLIM_DEM_LIM { get; set; }

    public short? DELAIS_DEM_LIM { get; set; }

    public short? DELAIS_ACC { get; set; }

    public string MODE_PAY_DEM_LIM { get; set; }

    public string MODE_PAY_ACC { get; set; }

    public bool? ACTIF_DEM_LIMI { get; set; }

    public int? REF_ACH_LIM { get; set; }
}
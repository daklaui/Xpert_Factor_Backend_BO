using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Features.Impaye.Queries.GetListehistorical;

public record GetListeHistoricalQuery_Response
    :ICreateMapper<T_IMPAYE_DTO>
{
    public int ID_IMP { get; set; }
    public int ID_ENC_IMP { get; set; }
    public int ID_DET_BORD_IMP { get; set; }
    public bool IS_RESOLU { get; set; }
    public string Encaissement { get; set; }
    public string Type { get; set; }
    public string Adherent { get; set; }
    public string Payeur { get; set; }
    public DateTime Date_de_reception { get; set; }
    public decimal MONT_ENC { get; set; }
    public DateTime DATE_IMP { get; set; }
    public DateTime DATE_SAISI_IMP { get; set; }
    public decimal MONT_IMP { get; set; }
}
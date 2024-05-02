using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities.DTO;

namespace CleanArc.Application.Features.Impaye.Queries;

public record GetListOfImpayeQuery_Response :ICreateMapper<T_IMPAYE_DTO>
{
    public int ID_ENC_IMP { get; set; }
    
    public decimal? MONT_IMP { get; set; }

    public DateTime? DATE_IMP { get; set; }
    
    public DateTime? DATE_SAISI_IMP { get; set; }
    
    public string TYP_ENC { get; set; }

    public int? REF_ADH_ENC { get; set; }
    
    public int? REF_ACH_ENC { get; set; }
}
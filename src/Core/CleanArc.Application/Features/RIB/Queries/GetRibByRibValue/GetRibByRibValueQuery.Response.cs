using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.RIB.Queries.GetRibByRibValue;

public class GetRibByRibValueQuery_Response: ICreateMapper<TR_RIB>
{
    
    public string RIB_RIB { get; set; }

    public int REF_IND_RIB { get; set; }

    public bool? ACTIF_RIB { get; set; }
}
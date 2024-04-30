using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.RIB.Queries.GetAllRibsByIndividuQueries;

public class GetAllRibsByIndividuQueryResult: ICreateMapper<TR_RIB>
{
    public string RIB_RIB { get; set; }

    public int REF_IND_RIB { get; set; }

    public bool? ACTIF_RIB { get; set; }
}
using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.AgencyBank.Queries.SearchAgencyQuerie;

public class SearchAgencyQueryResult:ICreateMapper<TR_Ag_Bq>
{
    public string Banque { get; set; }
    
}
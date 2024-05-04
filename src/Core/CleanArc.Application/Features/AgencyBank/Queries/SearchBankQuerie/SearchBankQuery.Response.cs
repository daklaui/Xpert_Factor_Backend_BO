using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.AgencyBank.Queries.RechercheBanqueQuerie;

public class SearchBankQueryResult : ICreateMapper<TR_Ag_Bq>
{
   

    public string Banque { get; set; }

}
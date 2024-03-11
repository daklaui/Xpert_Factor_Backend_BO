using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.AgencyBank.Queries.GetAgnecyBankByIdQuerie;

public class GetAllAgencyBankQueryResult : ICreateMapper<TR_Ag_Bq>
{
    public string Code_Bq_Ag { get; set; }

    public string Code_Bq { get; set; }

    public string Banque { get; set; }

    public string Code_Ag { get; set; }

    public string Agence { get; set; }
    
}
using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.Contact.Queries.GetIsContactBelongsToContract;

public class VerifContactExistsQuery_Response :ICreateMapper<T_CONTACT>
{


    public string NOM_PRE_CONTACT { get; set; }

    public string POS_CONTACT { get; set; }

    public string TEL1_CONTACT { get; set; }

    public string TEL2_CONTACT { get; set; }

    public string MAIL1_COONTACT { get; set; }

    public string MAIL2_COONTACT { get; set; }

    public string FAX_CONTACT { get; set; }

    public bool? ACTIF_CONTACT { get; set; }
}
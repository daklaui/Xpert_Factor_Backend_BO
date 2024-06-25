using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.Litige.Queries.GetAllLitiges;

public record GetAllLitigesQuery_Response:ICreateMapper<T_LITIGE>
{
    public string TYP_LIT { get; set; }

    public int REF_CTR_LIT { get; set; }

    public DateTime? DAT_LIT { get; set; }

    public DateTime? ECH_LIT { get; set; }

    public decimal? MONT_LT { get; set; }

    public bool? ETAT_LIT { get; set; }

    public short? ID_DET_BORD_LIT { get; set; }

    public int ID_LITIGE { get; set; }
}
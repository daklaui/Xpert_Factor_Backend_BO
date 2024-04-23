using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.TjDocumentDetBord.Queries.GetById;

public record GetByIdQueryResult : ICreateMapper<TJ_DOCUMENT_DET_BORD>
{
    public int ID_DOCUMENT_DET_BORD { get; set; }

    public string ID_DET_BORD { get; set; }

    public string NUM_BORD { get; set; }

    public int REF_CTR_DET_BORD { get; set; }

    public string REF_DOCUMENT_DET_BORD { get; set; }
}
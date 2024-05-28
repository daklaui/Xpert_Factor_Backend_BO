using CleanArc.Application.Profiles;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.TDetBord.Queries.DetailsDetBord;

public record GetDetailsDetBordQueryResult : ICreateMapper<DetailsDetBordDto>
{
    public List<DetailsDetBordDto> DetailsDetBordList { get; set; }
}
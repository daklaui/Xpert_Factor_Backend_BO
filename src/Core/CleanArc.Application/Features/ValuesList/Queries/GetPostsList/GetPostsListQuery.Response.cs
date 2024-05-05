using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.ValuesList.Queries.GetPostsList;

public class GetPostsListQueryResult : ICreateMapper<TR_CP>
{
    public string CP { get; set; }

    public string Ville { get; set; }

    public string Code_Gouvernorat { get; set; }

    public string Gouvernorat { get; set; }

    public string Code_Region { get; set; }

    public string Region { get; set; }

    public int ID_CP { get; set; }
}
using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.TR_CP.Queries.GetById
{
    public record GetByIdQueryResult : ICreateMapper<Domain.Entities.TR_CP>
    {
        
        public int ID_CP { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Code_Gouvernorat { get; set; }
        public string Gouvernorat { get; set; }
        public string Code_Region { get; set; }
        public string Region { get; set; }

       
    }
}
using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.TListVal.Queries.GetAllTListVals
{
    public record GetAllTListValsQueryResult : ICreateMapper<Domain.Entities.ListVals>
    {
        public int Id { get; set; }
        public string AbrListVal { get; set; }
        public string TypListVal { get; set; }
        public short OrdListVal { get; set; }
        public string LibListVal { get; set; }
        public string ComListVal { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public System.DateTime? ModifiedDate { get; set; }

        // Ajoutez d'autres propriétés de TListVal si nécessaire
    }
    
}

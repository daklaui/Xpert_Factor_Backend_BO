using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.TListVal.Queries.GetByIdQuery
{
    public record GetByIdQueryResult : ICreateMapper<Domain.Entities.ListVals>
    {
        public string AbrListVal { get; set; }
        public string TypListVal { get; set; }
        public short OrdListVal { get; set; }
        public string LibListVal { get; set; }
        public string ComListVal { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
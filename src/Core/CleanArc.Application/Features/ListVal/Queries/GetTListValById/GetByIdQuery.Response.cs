using CleanArc.Application.Profiles;

namespace CleanArc.Application.Features.ListVal.Queries.GetTListValById
{
    public record GetByIdQueryResult : ICreateMapper<Domain.Entities.TR_LIST_VAL>
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
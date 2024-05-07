using CleanArc.Application.Profiles;

namespace CleanArc.Application.Features.ListVal.Queries.GetAllTListVals
{
    public record GetAllTListValsQueryResult : ICreateMapper<Domain.Entities.TR_LIST_VAL>
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

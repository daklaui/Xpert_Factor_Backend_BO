using CleanArc.Application.Profiles;

namespace CleanArc.Application.Features.TPostalCodes.Queries.GetAllTPostalCodes
{
    public record GetAllTPostalCodesQueryResult : ICreateMapper<Domain.Entities.TPostalCodes>
    {
        public int Id { get; set; }
        public string CodeGouvernorat { get; set; }
        public string CodeRegion { get; set; }
        public string D_Cp { get; set; }
        public string Gouvernorat { get; set; }
        public string Region { get; set; }
        public string Ville { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public System.DateTime? ModifiedDate { get; set; }

        // Ajoutez d'autres propriétés de TPostalCodes si nécessaire
    }
}

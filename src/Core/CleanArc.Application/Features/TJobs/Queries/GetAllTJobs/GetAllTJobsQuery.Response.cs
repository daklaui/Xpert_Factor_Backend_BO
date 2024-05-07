using CleanArc.Application.Profiles;

namespace CleanArc.Application.Features.TJobs.Queries.GetAllTJobs
{
    public record GetAllTJobsQueryResult : ICreateMapper<Domain.Entities.TR_ACTPROF_BCT>
    {
        public int Id { get; set; }
        public string Code_Section { get; set; }
        public string Section { get; set; }
        public string Code_SousSection { get; set; }
        public string SousSection { get; set; }
        public string Code_Activite { get; set; }
        public string Code_Classe { get; set; }
        public string Classe { get; set; }
        public string Code_Classe1 { get; set; }
        public string Code_SousClasse { get; set; }
        public string SousClasse { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public System.DateTime? ModifiedDate { get; set; }

        // Ajoutez d'autres propriétés de TJob si nécessaire
    }
}

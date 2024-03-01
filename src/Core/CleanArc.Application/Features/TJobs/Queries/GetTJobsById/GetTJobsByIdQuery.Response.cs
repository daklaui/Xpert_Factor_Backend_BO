using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;
using System;

namespace  CleanArc.Application.Features.TJobs.Queries.GetTJobsById
{
    public record GetTJobsByIdQueryResult : ICreateMapper<Domain.Entities.TJobs>
    {
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
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}

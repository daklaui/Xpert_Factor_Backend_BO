using Mediator;
using CleanArc.Application.Models.Common;

namespace CleanArc.Application.Features.TJobs.Commands.UpdateTJobs
{
    public class UpdateTJobsCommand : IRequest<OperationResult<Unit>>
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
    }
}
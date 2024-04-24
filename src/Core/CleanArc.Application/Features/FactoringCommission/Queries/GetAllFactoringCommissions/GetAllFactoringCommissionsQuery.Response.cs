using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.FactoringCommission.Queries.GetAllFactoringCommissions
{
    public record GetAllFactoringCommissionsQueryResult : ICreateMapper<T_COMM_FACTORING>
    {
        public string TYP_COMM_FACTORING { get; set; }

        public int REF_CTR_COMM_FACTORING { get; set; }

        public decimal? TX_COMM_FACTORING { get; set; }

        public decimal? MONT_MIN_DOC_COMM_FACTORING { get; set; }

        public decimal? MONT_MIN_CTR_COMM_FACTORING { get; set; }
    }
}
using CleanArc.Application.Profiles;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.FraisDivers.Queries.GetAllFraisDivers
{
    public record GetAllFraisDiversQueryResult : ICreateMapper<T_FRAIS_DIVER>
    {
        public string TYP_FRAIS_DIVERS { get; set; }
        public int REF_CTR_FRAIS_DIVERS { get; set; }
        public decimal? MONT_PAR_UNIT_FRAIS_DIVERS { get; set; }
        public string LIB_FRAIS_DIVERS { get; set; }

    }
}
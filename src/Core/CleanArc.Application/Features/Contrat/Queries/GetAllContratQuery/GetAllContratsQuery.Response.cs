using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Features.Contrat.Queries.GetAllContrats
{
    public class GetAllContratsQueryResult
    {
        public List<T_FRAIS_DIVER> FraisDivers { get; set; }
        public List<T_FRAIS_PAIEMENT> FraisPaiements { get; set; }
        public List<T_COMM_FACTORING> CommFactorings { get; set; }
        public List<T_DEM_LIMITE> TDemLimites { get; set; }
        public List<T_INT_FINANCEMENT> TIntFinancements { get; set; }
        public T_DET_ASS TDetAss { get; set; }
        public List<T_FOND_GARANTIE> FondsGarantie { get; set; }
        public T_CONTRAT Contrat { get; set; }
    }
}
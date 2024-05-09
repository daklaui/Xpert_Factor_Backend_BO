using CleanArc.Domain.Entities;

namespace CleanArc.Domain.DTO;

public class ContractDetailsDTO
{
    public T_CONTRAT  Contrat { get; set; }
    public List<T_FRAIS_DIVER> fraisDiversDetails { get; set; }
    public List<T_FRAIS_PAIEMENT> fraisPaiementsDetails { get; set; }
    public List<T_COMM_FACTORING> commFactoringsDetails { get; set; }
    public List<TJ_CIR> tjCirsDetails { get; set; }
    public List<T_DEM_LIMITE> tDemLimitesDetails { get; set; }
    public List<T_INT_FINANCEMENT> tIntFinancementsDetails { get; set; }
    public T_DET_ASS tDetAssDetails { get; set; }
    public List<T_FOND_GARANTIE> tFondGarantiesDetails { get; set; }

    
}
using CleanArc.Domain.Entities;

namespace CleanArc.Domain.DTO;

public class ContractDTO
{
    public T_CONTRAT  Contrat { get; set; }
    public List<T_FRAIS_DIVERS_DTO> fraisDivers { get; set; }
    public List<T_FRAIS_PAIEMENT> fraisPaiements { get; set; }
    public List<T_COMM_FACTORING> commFactorings { get; set; }
    public List<TJ_CIR> tjCirs { get; set; }
    public List<T_DEM_LIMITE> tDemLimites { get; set; }
    public List<T_INT_FINANCEMENT> tIntFinancements { get; set; }
    public List<T_DET_ASS> tDetAss { get; set; }
    public List<T_FOND_GARANTIE> tFondGaranties { get; set; }
}
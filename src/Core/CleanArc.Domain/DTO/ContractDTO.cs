    using CleanArc.Domain.Entities;

    namespace CleanArc.Domain.DTO;

    public class  ContractDTO {
        public ContractDetailsDTO ContratDetail { get; set; }
        public int refAdh { get; set; }
        public List<T_FRAIS_DIVERS_DTO> fraisDivers { get; set; }
        public List<T_FRAIS_PAIEMENT_DTO> fraisPaiements { get; set; }
        public List<T_COMM_FACTORING_DTO> commFactorings { get; set; }
        public TJ_CIR individualRelationContract { get; set; }
        public List<TJ_CIR> buyers { get; set; }
        public List<T_DEM_LIMITE_DTO> tDemLimites { get; set; }
        public List<T_INT_FINANCEMENT_DTO> tIntFinancements { get; set; }
        public T_DET_ASS_DTO tDetAss { get; set; }
        public List<T_FOND_GARANTIE_DTO> tFondGaranties { get; set; }
       
        
    }
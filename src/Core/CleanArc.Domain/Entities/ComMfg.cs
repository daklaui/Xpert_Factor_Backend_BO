using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TComMfg:BaseEntity,IEntity
{
        public string TypeMfg { get; set; }
        public string RefAdhMfg { get; set; }
        public string CodeMfg { get; set; }
        public decimal MntCommMfg { get; set; }
        public int NumBordMfg { get; set; }
        public  Nullable<System.DateTime> DateSaisieMfg { get; set; }
        public  Nullable<System.DateTime> DateEnvoieMfg { get; set; }
        public bool FlagMfg { get; set; }
        public string TypeActionMfg { get; set; }
        
        public int idContrat { get; set; } 
        public TContrat Contrat { get; set; } = null!;
    
}
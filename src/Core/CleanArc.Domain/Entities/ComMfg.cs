using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TComMfg:BaseEntity,IEntity
{
    public int IdMfg { get; set; }
        public string TypeMfg { get; set; }
        public string RefAdhMfg { get; set; }
        public string CodeMfg { get; set; }
        public decimal MntCommMfg { get; set; }
        public int NumBordMfg { get; set; }
        public  Nullable<System.DateTime> DateSaisieMfg { get; set; }
        public  Nullable<System.DateTime> DateEnvoieMfg { get; set; }
        public bool FlagMfg { get; set; }
        public string TypeActionMfg { get; set; }
        public int TContratRefCtr { get; set; }
        public virtual ICollection<TFondGarantie> FondGaranties { get; set; }

    
}
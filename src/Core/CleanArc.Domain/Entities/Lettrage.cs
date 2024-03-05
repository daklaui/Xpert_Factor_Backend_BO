﻿using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TJLettrage:BaseEntity,IEntity
{
    public int IdDetBordLet { get; set; }
    public int IdEncLet { get; set; }
    public Nullable<System.DateTime> DatLet { get; set; }
    public decimal MontTtcLet { get; set; }
    public Nullable<System.DateTime> DatReconcil { get; set; }
    public bool ValideLet { get; set; }
    public bool ValideReconcil { get; set; }
    public int TEncaissementIdEnc { get; set; }
    public int TDetBordIdDetBord { get; set; }
    public int TDetBordRefCtrDetBord { get; set; }
    
    public int idEncaissement { get; set; } 
    public TEncaissement Encaissement { get; set; } = null!;
    
    public int idDetBord { get; set; } 
    public TDetBord DetBordt { get; set; } = null!;
    

}
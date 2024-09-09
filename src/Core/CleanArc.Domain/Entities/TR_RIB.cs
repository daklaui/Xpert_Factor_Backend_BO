using CleanArc.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArc.Domain.Entities;

public partial class TR_RIB : IEntity
{
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int ID_RIB { get; set; }
    public string RIB_RIB { get; set; }

    public int REF_IND_RIB { get; set; }

    public bool? ACTIF_RIB { get; set; }
}

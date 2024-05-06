using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class TR_LIST_VAL: IEntity
{
    public string ABR_LIST_VAL { get; set; }

    public string TYP_LIST_VAL { get; set; }

    public short? ORD_LIST_VAL { get; set; }

    public string LIB_LIST_VAL { get; set; }

    public string COM_LIST_VAL { get; set; }

    public int ID_LIST_VAL { get; set; }

    public int? NB_JOUR_LIST_VAL { get; set; }

    public string TYPE_RECOUVREMENT { get; set; }

    public virtual ICollection<TJ_GRP_PERMISSION> TJ_GRP_PERMISSIONs { get; } = new List<TJ_GRP_PERMISSION>();
}

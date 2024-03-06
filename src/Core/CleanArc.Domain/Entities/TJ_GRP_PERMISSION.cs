using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TJ_GRP_PERMISSION
{
    public int ID_GRP { get; set; }

    public int ID_PERMISSION { get; set; }

    public virtual TR_LIST_VAL ID_PERMISSIONNavigation { get; set; }
}

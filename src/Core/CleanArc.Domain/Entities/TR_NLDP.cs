using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TR_NLDP 
{
    public int ID_NLDP { get; set; }

    public string LIB_NT { get; set; }

    public string ABRV_NAT { get; set; }

    public string LIB_LANG { get; set; }

    public string ABRV_LANG { get; set; }

    public string LIB_DEVISE { get; set; }

    public string ABRV_DEVISE { get; set; }

    public string LIB_PAYS { get; set; }

    public string ABRV_PAYS { get; set; }
}

using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TJ_DOCUMENT_DET_BORD
{
    public int ID_DOCUMENT_DET_BORD { get; set; }

    public string ID_DET_BORD { get; set; }

    public string NUM_BORD { get; set; }

    public int REF_CTR_DET_BORD { get; set; }

    public string REF_DOCUMENT_DET_BORD { get; set; }
}

using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_GROUPE
{
    public int ID_GROUP { get; set; }

    public int? REF_IND_GROUP { get; set; }

    public string NOM_GROUP { get; set; }
}

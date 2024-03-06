using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_EMAIL
{
    public int ID_EMAIL { get; set; }

    public int ID_USER { get; set; }

    public string TITRE_GROUPE { get; set; }
}

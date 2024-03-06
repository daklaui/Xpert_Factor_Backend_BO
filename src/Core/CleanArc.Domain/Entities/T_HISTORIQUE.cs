using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_HISTORIQUE
{
    public int ID_HISTORIQUE { get; set; }

    public DateTime? DATE_ACTION { get; set; }

    public string ACTION { get; set; }

    public string T_TABLE { get; set; }

    public string ID_ENREGISTREMENT { get; set; }

    public string LOGIN_USER { get; set; }

    public string IP_PC { get; set; }

    public string NOM_PC { get; set; }

    public string REF_CTR_HIST { get; set; }

    public string REF_IND_HIST { get; set; }

    public string ABREV_ROLE_HIST { get; set; }

    public int ID_HISTORIQUEE { get; set; }
}

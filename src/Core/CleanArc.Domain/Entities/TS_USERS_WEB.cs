using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class TS_USERS_WEB
{
    public int ID_USER_WEB { get; set; }

    public int REF_IND_WEB { get; set; }

    public string LOGIN_WEB { get; set; }

    public string PASSWORD_WEB { get; set; }

    public string LOGO_WEB { get; set; }

    public bool ACTIF_USER_WEB { get; set; }

    public DateTime? DATE_FIN_COMPTE { get; set; }

    public string ONE_SIGNAL_PLAYER_ID { get; set; }
}

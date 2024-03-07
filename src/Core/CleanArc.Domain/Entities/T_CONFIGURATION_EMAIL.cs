using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_CONFIGURATION_EMAIL
{
    public int? ID_FACTOR { get; set; }

    public string EMAIL { get; set; }

    public string MDP { get; set; }

    public string SMTP { get; set; }

    public int? PORT { get; set; }

    public bool? EnableSsl { get; set; }

    public int ID { get; set; }
}

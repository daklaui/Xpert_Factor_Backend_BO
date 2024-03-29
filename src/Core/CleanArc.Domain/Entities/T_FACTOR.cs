﻿using System;
using System.Collections.Generic;

namespace CleanArc.Domain.Entities;

public partial class T_FACTOR
{
    public int ID_FACTOR { get; set; }

    public string RAISON_SOCIAL { get; set; }

    public string ABRV { get; set; }

    public string RC { get; set; }

    public string MF { get; set; }

    public string CODE_TVA { get; set; }

    public string CODE_DOUANE { get; set; }

    public string ADRESSE { get; set; }

    public string CAPITAL { get; set; }

    public string CAPITAL_LETTRE { get; set; }

    public byte[] LOGO_16 { get; set; }

    public byte[] LOGO_32 { get; set; }

    public byte[] LOGO_48 { get; set; }

    public string EMAIL { get; set; }

    public string TEL { get; set; }

    public string FAX { get; set; }

    public string SITE_WEB { get; set; }

    public string EXERCICE { get; set; }

    public string DEVISE { get; set; }

    public string LANGUE { get; set; }

    public string PAYS { get; set; }

    public string SRV_DB { get; set; }

    public string DB { get; set; }

    public string CNX_DB { get; set; }

    public string MDP_CNX { get; set; }

    public bool? Det_Doc_GED { get; set; }
}

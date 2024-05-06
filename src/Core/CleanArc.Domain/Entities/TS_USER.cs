﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CleanArc.Domain.Common;
using CleanArc.Domain.Entities.User;

namespace CleanArc.Domain.Entities;

public partial class TS_USER : IEntity
{
    
    public int ID_USER { get; set; }

    public int ID_GRP_USER { get; set; }

    public string NOM_USER { get; set; }
    public string PRE_USER { get; set; }

    public string LOGIN_USER { get; set; }

    public string MDP_USER { get; set; }

    public bool ACTIF_USER { get; set; }
    public string FONCTION_USER { get; set; }

    public string SERVICE_USER { get; set; }

    public string DIRECTION_USER { get; set; }
    public string AGENCE_USER { get; set; }

    public string MAIL_USER { get; set; }

    public string TEL_FIXE_USER { get; set; }

    public string MOBILE_USER { get; set; }
    
    public ROLES Roles { get; set; } 

}
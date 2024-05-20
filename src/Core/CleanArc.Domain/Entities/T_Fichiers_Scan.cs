using System;
using System.Collections.Generic;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public partial class T_Fichiers_Scan:IEntity
{
    public int Id_Scan { get; set; }

    public string Nom_Fichier_Scan { get; set; }

    public DateTime? Date_Scan { get; set; }

    public string Adresse_Scan { get; set; }

    public string Affect_Scan { get; set; }

    public string Nom_Fichier_SansEXT { get; set; }
}

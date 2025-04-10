using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities.Profil;

    public class Profil:BaseEntity
    {
        [Key] 
        public int Id_Profile { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public string Manager { get; set; } 
        public string StartDate { get; set; }

        public string Project { get; set; } 

        public string CV { get; set; } 

        public string Certifications { get; set; } 
    }

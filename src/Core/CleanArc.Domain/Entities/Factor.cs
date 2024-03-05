using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TFactor :BaseEntity,IEntity
{
   public string RaisonSocial { get; set; }
   public string Arbv { get; set; }
   public string RC { get; set; }
   public string MF { get; set; }
   public string CodeTva { get; set; }
   public string CodeDouane { get; set; }
   public string Adresse { get; set; }
   public string Capital { get; set; }
   public string CapitalLettre { get; set; }
   public string Logo16 { get; set; }
   public string Logo32 { get; set; }
   public string Logo48 { get; set; }
   public string Email { get; set; }
   public string Tel { get; set; }
   public string Fax { get; set; }
   public string SiteWeb { get; set; }
   public string Exercice { get; set; }
   public string Devise { get; set; }
   public string Langue { get; set; }
   public string Pays { get; set; }
   public string SrvDb { get; set; }
   public string Db { get; set; }
   public string CnxDb { get; set; }
   public string MdpCnx { get; set; }
   public byte DetDocGed { get; set; }
   
   public  ICollection<TRTva> Tvas { get; }= new List<TRTva>();
   public  ICollection<TRAgBq> AgBqs { get; }= new List<TRAgBq>();
   public  ICollection<TRListFraisDivers> FraisDiversCollection{ get; }= new List<TRListFraisDivers>();
   public  ICollection<TRActprofBct> ActprofBcts{ get; }= new List<TRActprofBct>();
   public  ICollection<TRIntFinancement> TrIntFinancements{ get; }= new List<TRIntFinancement>();
   public  ICollection<TContrat> Contrats{ get; }= new List<TContrat>();
   public  ICollection<TRComFactoring> ComFactorings{ get; }= new List<TRComFactoring>();
   public  ICollection<TRibFactor> RibFactors{ get; }= new List<TRibFactor>();
   public  ICollection<TConfigurationEmai> ConfigurationEmais { get; }= new List<TConfigurationEmai>();
   public  ICollection<TRCp> Cps { get; }= new List<TRCp>();
   public  ICollection<TRNldp> Nldps { get; }= new List<TRNldp>();
   public  ICollection<TRParamPiece> TrParamPieces { get; }= new List<TRParamPiece>();
   public  ICollection<TUser> Users { get; }= new List<TUser>();

   
   public int idTMM { get; set; }
   public  TRTMM Trtmm { get; set; }= null!;
 
   
   
   
  
}
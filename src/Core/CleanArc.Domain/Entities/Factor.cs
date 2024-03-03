using CleanArc.Domain.Common;

namespace CleanArc.Domain.Entities;

public class TFactor :BaseEntity,IEntity
{
   public int IdFactor { get; set; }
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
   public virtual ICollection<TRTMM> Ttmms { get; set; }
   public TRibFactor RibFactor { get; set; }
   public TRComFactoring TrComFactoring { get; set; }
   public TRIntFinancement TrIntFinancement { get; set; }
   public TRActprofBct TrActprofBct { get; set; }
   public TRAgBq AgBq { get; set; }
   public TRTva Tva { get; set; }
   public TRParamPiece ParamPiece { get; set; }
   public TRNldp Nldp { get; set; }
   public TRCp Cp { get; set; }
   public int CpId { get; set; }
   public TContrat Contrat { get; set; }
   public TUser User { get; set; }
}

using CleanArc.Domain.Common;
using CleanArc.Domain.Entities;

public class TIndividu : BaseEntity, IEntity
{
    
        public string GenreInd { get; set; }
        public string TypDocIdInd { get; set; }
        public string NumDocIdInd { get; set; }
        public string LieuDocIdInd { get; set; }
        public Nullable<System.DateTime> DateDocIdInd { get; set; }
        public string CodTvaInd { get; set; }
        public string NomInd { get; set; }
        public string PreInd { get; set; }
        public Nullable<System.DateTime> DatNaissCreat { get; set; }
        public Nullable<bool> GrpInd { get; set; }
        public Nullable<decimal> LimCredGloInd { get; set; }
        public Nullable<decimal> LimFinGloInd { get; set; }
        public string InfoInd { get; set; }
        public Nullable<System.DateTime> DatInfoInd { get; set; }
        public Nullable<int> IdNldp { get; set; }
        public string CodSclas { get; set; }
        public string AbrvInd { get; set; }
        public string PhotoInd { get; set; }
        public string MfInd { get; set; }
        public string RcInd { get; set; }
        public Nullable<bool> ExoTva { get; set; }
        public Nullable<System.DateTime> DatDebExo { get; set; }
        public Nullable<System.DateTime> DatFinExo { get; set; }
        public string TelInd { get; set; }
        public string FaxInd { get; set; }
        public string EmailInd { get; set; }
        public string RefAdhInd { get; set; }
        public string FromJurInd { get; set; }
        public Nullable<bool> ExoInd { get; set; }
        public string AdrInd { get; set; }
        public string CpInd { get; set; }
        public string RefAchInd { get; set; }
        public virtual ICollection<TRib> Ribs { get; set; }
        public virtual ICollection<TContact> Contacts { get; set; }

}
 
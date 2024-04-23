using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface ILimiteRepository
{
    Task<T_DEM_LIMITE> AddTDemLimitesync(T_DEM_LIMITE demLimite);
    /**
     * 
     * var ctr = db.T_CONTRAT.Where(p => p.REF_CTR == Nom_Adh).FirstOrDefault();
            if (ctr != null)
            {
                try
                {
                    


                    if (ctr.TYP_CTR.Trim() == "3")
                    {
                        T_DEM_LIMITE dem = new T_DEM_LIMITE();
                        dem.REF_CTR_DEM_LIM = Nom_Adh;
                        dem.TYP_DEM_LIM = "CRE";
                        dem.DATLIM_DEM_LIM = DateTime.Now;
                        dem.DAT_DEM_LIM = DateTime.Now;
                        dem.MONT_DEM_LIM = ParseDecimalOrDefault(Limite_Credit.Replace(" ", ""));
                        dem.DECISION_LIM = "D";
                        dem.DEVISE = "TND";
                        dem.REF_ACH_LIM = Nom_Ach;
                        dem.MODE_PAY_DEM_LIM = Mode_Paye;
                        //dem.MONT_LIM_ACH_ADH = ParseDecimalOrDefault(MNT_Ach_Adh.Replace(" ", ""));
                        dem.DELAIS_DEM_LIM = short.Parse(Delai.ToString());
                        dem.ACTIF_DEM_LIMI = false;
                        db.T_DEM_LIMITE.Add(dem);
                        db.SaveChanges();

                    }

                    T_DEM_LIMITE demlimit = new T_DEM_LIMITE
                    {
                        REF_CTR_DEM_LIM = Nom_Adh,
                        TYP_DEM_LIM = "FIN",
                        DAT_DEM_LIM = DateTime.Now,
                        DATLIM_DEM_LIM = DateTime.Now,
                        DECISION_LIM = "D",// demande
                        MONT_DEM_LIM = ParseDecimalOrDefault(Limite_fin.Replace(" ", "")),
                        DEVISE = Devis,
                        // MONT_LIM_ACH_ADH = ParseDecimalOrDefault(MNT_Ach_Adh.Replace(" ", "")),
                        DELAIS_DEM_LIM = short.Parse(Delai.ToString()),
                        MODE_PAY_DEM_LIM = Mode_Paye,
                        ACTIF_DEM_LIMI = false,
                        REF_ACH_LIM = Nom_Ach
                    };

                    db.T_DEM_LIMITE.Add(demlimit);
     * 
     **/

    Task<DemLimListingDTO> checkExistingLimiteNoActif(int refCtr, int refInd);
    /*
     
     var tab = from dem in db.T_DEM_LIMITE
                      join iach in db.T_INDIVIDU on dem.REF_ACH_LIM equals iach.REF_IND
                      join cach in db.TJ_CIR on dem.REF_CTR_DEM_LIM equals cach.REF_CTR_CIR
                      where (cach.ID_ROLE_CIR == "ACH" && cach.REF_IND_CIR == id2 && cach.REF_IND_CIR == dem.REF_ACH_LIM
                                                    && dem.ACTIF_DEM_LIMI == false
                                                    && (dem.DECISION_LIM != "RF" && dem.DECISION_LIM != "V" && dem.DECISION_LIM != "C")

                                                    && dem.REF_CTR_DEM_LIM == id)
                      select new
                      {
                          dem.REF_CTR_DEM_LIM,
                          dem.REF_ACH_LIM,
                          dem.ACTIF_DEM_LIMI,
                          dem.DAT_DEM_LIM,
                          dem.REF_DEM_LIM,
                          dem.DECISION_LIM,
                          dem.DELAIS_DEM_LIM,
                          dem.DEVISE,
                          dem.MODE_PAY_DEM_LIM,
                          dem.MONT_DEM_LIM,
                          dem.SORT_DEM_LIM,
                          dem.TYP_DEM_LIM,
                          dem.DELAIS_ACC,
                          dem.MONT_ACC,
                          dem.MODE_PAY_ACC,
                          iach.NOM_IND
                      };
            return Json(new { success = tab.Count() > 0, message = $"Demande de Limite de Financement en attente de validation " });
     
     */

    Task<List<DemandeLimiteDTO>> getListOfDemLimitNoActif();
    /**
     * 
      List<T_DEM_LIMITE_DTO> demLim = (from dem in db.T_DEM_LIMITE
                                             join iach in db.T_INDIVIDU on dem.REF_ACH_LIM equals iach.REF_IND
                                             join cach in db.TJ_CIR on dem.REF_CTR_DEM_LIM equals cach.REF_CTR_CIR
                                             join ctr in db.T_CONTRAT on dem.REF_CTR_DEM_LIM equals ctr.REF_CTR
                                             where (cach.ID_ROLE_CIR == "ACH" && cach.REF_IND_CIR == dem.REF_ACH_LIM
                                                    && dem.ACTIF_DEM_LIMI == false
                                                     && dem.DECISION_LIM != "RF"
                                                    && dem.MONT_ACC != null
                                                    && (dem.COMMENT != null && dem.COMMENT != ""))
                                             select new T_DEM_LIMITE_DTO
                                             {
                                                 REF_CTR_PAPIER_CTR = ctr.REF_CTR_PAPIER_CTR,
                                                 REF_CTR_DEM_LIM = dem.REF_CTR_DEM_LIM,
                                                 COMMENT = dem.COMMENT,
                                                 REF_ACH_LIM = dem.REF_ACH_LIM,
                                                 ACTIF_DEM_LIMI = dem.ACTIF_DEM_LIMI,
                                                 DAT_DEM_LIM = dem.DAT_DEM_LIM,
                                                 REF_DEM_LIM = dem.REF_DEM_LIM,
                                                 DELAIS_DEM_LIM = dem.DELAIS_DEM_LIM,
                                                 DEVISE = dem.DEVISE,
                                                 MODE_PAY_DEM_LIM = DisplayTextWithoutAbr(dem.MODE_PAY_DEM_LIM),
                                                 MONT_DEM_LIM = (decimal)dem.MONT_DEM_LIM,
                                                 SORT_DEM_LIM = dem.SORT_DEM_LIM,
                                                 TYP_DEM_LIM = DisplayTextWithoutAbr(dem.TYP_DEM_LIM),
                                                 DELAIS_ACC = dem.DELAIS_ACC,
                                                 MONT_ACC = (decimal)dem.MONT_ACC,
                                                 MODE_PAY_ACC = DisplayTextWithoutAbr(dem.MODE_PAY_ACC),
                                                 NOM_IND = iach.NOM_IND
                                             }).ToList();
            ViewBag.FinalValidationsList = demLim;
     
     
     */


    Task<List<DemandeLimiteDTO>> getAllLDemLimites();
    /*
     
     List<T_DEM_LIMITE_DTO> demLim = (from dem in db.T_DEM_LIMITE
                                             join iach in db.T_INDIVIDU on dem.REF_ACH_LIM equals iach.REF_IND
                                             join cach in db.TJ_CIR on dem.REF_CTR_DEM_LIM equals cach.REF_CTR_CIR
                                             join ctr in db.T_CONTRAT on dem.REF_CTR_DEM_LIM equals ctr.REF_CTR
                                             where (cach.ID_ROLE_CIR == "ACH" && cach.REF_IND_CIR == dem.REF_ACH_LIM)
                                             orderby dem.DAT_DEM_LIM descending
                                             //&& dem.ACTIF_DEM_LIMI == false
                                             // && dem.DECISION_LIM != "RF"
                                             // && dem.MONT_ACC != null
                                             //&& (dem.COMMENT != null && dem.COMMENT != ""))
                                             select new T_DEM_LIMITE_DTO
                                             {
                                                 REF_CTR_PAPIER_CTR = ctr.REF_CTR_PAPIER_CTR,
                                                 REF_CTR_DEM_LIM = dem.REF_CTR_DEM_LIM,
                                                 COMMENT = dem.COMMENT,
                                                 DECISION_LIM = DisplayTextWithoutAbr(dem.DECISION_LIM),
                                                 REF_ACH_LIM = dem.REF_ACH_LIM,
                                                 ACTIF_DEM_LIMI = dem.ACTIF_DEM_LIMI,
                                                 DAT_DEM_LIM = dem.DAT_DEM_LIM,
                                                 REF_DEM_LIM = dem.REF_DEM_LIM,
                                                 DELAIS_DEM_LIM = dem.DELAIS_DEM_LIM,
                                                 DEVISE = dem.DEVISE,
                                                 MODE_PAY_DEM_LIM = DisplayTextWithoutAbr(dem.MODE_PAY_DEM_LIM),
                                                 MONT_DEM_LIM = dem.MONT_DEM_LIM != null ? (decimal)dem.MONT_DEM_LIM : 0,
                                                 SORT_DEM_LIM = dem.SORT_DEM_LIM,
                                                 TYP_DEM_LIM = DisplayTextWithoutAbr(dem.TYP_DEM_LIM),
                                                 DELAIS_ACC = dem.DELAIS_ACC,
                                                 MONT_ACC = dem.MONT_ACC != null ? (decimal)dem.MONT_ACC : 0,
                                                 MODE_PAY_ACC = DisplayTextWithoutAbr(dem.MODE_PAY_ACC),
                                                 NOM_IND = iach.NOM_IND
                                             }).ToList();
            ViewBag.FinalValidationsList = demLim;
     
     */

    Task<bool> validateLimite(int id);
    /*
       var limite = db.T_DEM_LIMITE.Where(p => p.REF_DEM_LIM == id).FirstOrDefault();
     if (limite != null)
            {
                limite.DECISION_LIM = "V" RF;
                limite.ACTIF_DEM_LIMI = true false;
                db.T_DEM_LIMITE.Update(limite);
                db.SaveChanges();}
     */
}
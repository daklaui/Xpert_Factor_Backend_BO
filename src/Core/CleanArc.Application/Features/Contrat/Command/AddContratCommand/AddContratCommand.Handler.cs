using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;

namespace CleanArc.Application.Features.Contrat.Commands.AddContratCommand
{
    internal class AddContratCommandHandler : IRequestHandler<AddContratCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddContratCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        private decimal ParseDecimalOrDefault(string value)
        {
            decimal result;
            if (decimal.TryParse(value, out result))
            {
                return result;
            }
            return 0;
        }


        private void CreateOrUpdateFraisDiversAsync(List<T_FRAIS_DIVERS_DTO> fraisDivers, int refContract)
        {
            try
            {
                foreach (T_FRAIS_DIVERS_DTO fraisDiver in fraisDivers)
                {
                    try
                    {
                        var currentFin = _unitOfWork.FraisDiversRepository.GetFraisDiversByRefCtrAndType(refContract, fraisDiver.TYP_FRAIS_DIVERS).Result;
                        if (currentFin != null)
                        {
                            currentFin.LIB_FRAIS_DIVERS = fraisDiver.LIB_FRAIS_DIVERS;
                            currentFin.MONT_PAR_UNIT_FRAIS_DIVERS = ParseDecimalOrDefault(fraisDiver.MONT_PAR_UNIT_FRAIS_DIVERS);
                            currentFin.REF_CTR_FRAIS_DIVERS = refContract;
                            currentFin.TYP_FRAIS_DIVERS = fraisDiver.TYP_FRAIS_DIVERS;
                            _unitOfWork.FraisDiversRepository.UpdateFraisDiversAsync(currentFin);
                        }
                        else
                        {
                            T_FRAIS_DIVERS frais_divers = new T_FRAIS_DIVERS();

                            frais_divers.LIB_FRAIS_DIVERS = fraisDiver.LIB_FRAIS_DIVERS;
                            frais_divers.MONT_PAR_UNIT_FRAIS_DIVERS = ParseDecimalOrDefault(fraisDiver.MONT_PAR_UNIT_FRAIS_DIVERS);
                            frais_divers.REF_CTR_FRAIS_DIVERS = refContract;
                            frais_divers.TYP_FRAIS_DIVERS = fraisDiver.TYP_FRAIS_DIVERS;

                            _unitOfWork.FraisDiversRepository.AddFraisDiversAsync(frais_divers);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error d'enregistrement Frais divers.", e);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error d'enregistrement Frais divers.", e);
            }
        }
        private void AddAdherent(int refContract, TJ_CIR individualRelationContract, int adherentRefId, string type_contrat)
        {
            try
            {
                var currentCir = _unitOfWork.tjcirRepository.GetExistingActorsByRefCtr("ADH" ,refContract);

                if (currentCir == null)
                {
                    individualRelationContract.REF_CTR_CIR = refContract;
                    individualRelationContract.ID_ROLE_CIR = "ADH";
                    individualRelationContract.REF_IND_CIR = adherentRefId;
                    _unitOfWork.tjcirRepository.UpdateCirAsync(individualRelationContract);
 
                }
                else
                {
                    if (currentCir.REF_IND_CIR != adherentRefId)
                    {
                        currentCir.REF_IND_CIR = adherentRefId;
                        db.TJ_CIR.Update(currentCir);
                        db.SaveChanges();
                    }
                }



                if (type_contrat.Contains("Contrat_Reverse"))
                {
                    TJ_CIR cir2 = new TJ_CIR();
                    cir2.REF_CTR_CIR = refContract;
                    cir2.ID_ROLE_CIR = "ACH";
                    cir2.REF_IND_CIR = adherentRefId;
                    db.TJ_CIR.Add(cir2);
                    db.SaveChanges();
                }


            }
            catch (Exception e)
            {

                HandleError("   Error d enregistrement Adhérent ");
            }

        }


        public async ValueTask<OperationResult<bool>> Handle(AddContratCommand request, CancellationToken cancellationToken)
        {
            T_CONTRAT Contrat = request.Contrat.Contrat;

            try
            {
                T_CONTRAT validerContrat = new T_CONTRAT();

                validerContrat.REF_CTR_PAPIER_CTR = Contrat.REF_CTR_PAPIER_CTR;
                validerContrat.CA_CTR = Contrat.CA_CTR;
                validerContrat.CA_CTR = Contrat.CA_CTR;
                validerContrat.CA_EXP_CTR = Contrat.CA_EXP_CTR;
                validerContrat.CA_IMP_CTR = Contrat.CA_IMP_CTR;
                validerContrat.DAT_CREATION_CTR = DateTime.Now;
                validerContrat.DELAI_MAX_REG_CTR = Contrat.DELAI_MAX_REG_CTR;
                validerContrat.DELAI_MOYEN_REG_CTR = Contrat.DELAI_MOYEN_REG_CTR;
                validerContrat.LIM_FIN_CTR = Contrat.LIM_FIN_CTR;
                validerContrat.NB_ACH_PREVU_CTR = Contrat.NB_ACH_PREVU_CTR;
                validerContrat.NB_AVOIRS_PREVU_CTR = Contrat.NB_AVOIRS_PREVU_CTR;
                validerContrat.NB_FACT_PREVU_CTR = Contrat.NB_FACT_PREVU_CTR;
                validerContrat.NB_REMISES_PREVU_CTR = Contrat.NB_REMISES_PREVU_CTR;
                validerContrat.SERVICE_CTR = Contrat.SERVICE_CTR;
                validerContrat.IS_NOTIFIED = Contrat.IS_NOTIFIED;
                validerContrat.RESP_CTR_1 = Contrat.RESP_CTR_1;
                validerContrat.STATUT_CTR = "R";

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            await _unitOfWork.ContratRepository.AddContratAsync(request.Contrat.Contrat);
            CreateOrUpdateFraisDiversAsync(request.Contrat.fraisDivers, Contrat.REF_CTR);


            await _unitOfWork.CommitAsync();
            return OperationResult<bool>.SuccessResult(true);
        }
    }
}

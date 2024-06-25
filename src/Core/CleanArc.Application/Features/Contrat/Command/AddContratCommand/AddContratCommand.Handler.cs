using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using CleanArc.Domain.Entities;
using Mediator;
using T_DEM_LIMITE_DTO = CleanArc.Domain.DTO.T_DEM_LIMITE_DTO;

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
        private async Task CreateFraisDiversAsync(List<T_FRAIS_DIVERS_DTO> fraisDivers, int refContract)
        {
            try
            {
                foreach (var fraisDiver in fraisDivers)
                {
                    T_FRAIS_DIVER frais_divers = new T_FRAIS_DIVER
                    {
                        LIB_FRAIS_DIVERS = fraisDiver.LIB_FRAIS_DIVERS,
                        MONT_PAR_UNIT_FRAIS_DIVERS = ParseDecimalOrDefault(fraisDiver.MONT_PAR_UNIT_FRAIS_DIVERS),
                        REF_CTR_FRAIS_DIVERS = refContract,
                        TYP_FRAIS_DIVERS = fraisDiver.TYP_FRAIS_DIVERS
                    };

                    await _unitOfWork.FraisDiversRepository.AddFraisDiversAsync(frais_divers);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error lors de l'enregistrement des Frais divers.", e);
                
            }
        }
        private async Task CreateFondGarantieAsync(List<T_FOND_GARANTIE_DTO> fonds, int refContract)
        {
            try
            {
                foreach (var fond in fonds)
                {
                    T_FOND_GARANTIE fondGarantieEntity = new T_FOND_GARANTIE
                    {
                        REF_CTR_FDG = refContract,
                        TYP_FDG = fond.TYP_FDG,
                        LIB_FDG = fond.LIB_FDG,
                        TX_FDG = fond.TX_FDG,
                        MONT_MAX_FDG = fond.MONT_MAX_FDG,
                        MONT_MIN_FDG = fond.MONT_MIN_FDG,
                        TYP_DOC_REMIS_FDG = fond.TYP_DOC_REMIS_FDG
                    };

                    await _unitOfWork.FondGarantieRepository.AddFondGarantieAsync(fondGarantieEntity);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during registration of Fond Garantie.", e);
                
            }
        }
        
        private async Task CreateCommFactoringAsync(List<T_COMM_FACTORING_DTO> commFactorings, int refContract)
        {
            try
            {
                foreach (var commFactoring in commFactorings)
                {
                    T_COMM_FACTORING commFactoringEntity = new T_COMM_FACTORING
                    {
                        TYP_COMM_FACTORING = commFactoring.TYP_COMM_FACTORING,
                        TX_COMM_FACTORING = commFactoring.TX_COMM_FACTORING,
                        MONT_MIN_DOC_COMM_FACTORING = commFactoring.MONT_MIN_DOC_COMM_FACTORING,
                        MONT_MIN_CTR_COMM_FACTORING = commFactoring.MONT_MIN_CTR_COMM_FACTORING,
                        REF_CTR_COMM_FACTORING = refContract
                    };

                    await _unitOfWork.FactoringCommissionRepository.AddFactoringCommissionAsync(commFactoringEntity);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during Comm Factoring registration.", e);
               
            }
        }

        private async Task CreateFraisPaiementAsync(List<T_FRAIS_PAIEMENT_DTO> fraisPaiements, int refContract)
        {
            try
            {
                foreach (var fraisPaiement in fraisPaiements)
                {
                    T_FRAIS_PAIEMENT fraisPaiementEntity = new T_FRAIS_PAIEMENT
                    {
                        TYP_FRAIS_PAIE = fraisPaiement.TYP_FRAIS_PAIE,
                        MONT_PAR_INSTR_FRAIS_PAIE = fraisPaiement.MONT_PAR_INSTR_FRAIS_PAIE,
                        LIB_FRAIS_PAIE = fraisPaiement.LIB_FRAIS_PAIE,
                        REF_CTR_FRAIS_PAIE = refContract
                    };

                    await _unitOfWork.FraisPaiementRepository.AddFraisPaiementAsync(fraisPaiementEntity);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during Payment Fees registration.", e);
            }
        }


        private async Task CreateDemandeLimiteAsync(List<T_DEM_LIMITE_DTO> demandesLimite, int refContract)
{
    try
    {
        foreach (var demandeLimite in demandesLimite)
        {
            T_DEM_LIMITE demandeLimiteEntity = new T_DEM_LIMITE
            {
                TYP_DEM_LIM = demandeLimite.TYP_DEM_LIM,
                DAT_DEM_LIM = demandeLimite.DAT_DEM_LIM,
                SORT_DEM_LIM = demandeLimite.SORT_DEM_LIM,
                MONT_DEM_LIM = demandeLimite.MONT_DEM_LIM,
                DEVISE = demandeLimite.DEVISE,
                DATLIM_DEM_LIM = demandeLimite.DATLIM_DEM_LIM,
                DECISION_LIM = demandeLimite.DECISION_LIM,
                MONT_ACC = demandeLimite.MONT_ACC,
                MONT_LIM_ACH_ADH = demandeLimite.MONT_LIM_ACH_ADH,
                DAT_ANNUL_DEM_LIM = demandeLimite.DAT_ANNUL_DEM_LIM,
                DELAIS_DEM_LIM = demandeLimite.DELAIS_DEM_LIM,
                MODE_PAY_DEM_LIM = demandeLimite.MODE_PAY_DEM_LIM,
                MODE_PAY_ACC = demandeLimite.MODE_PAY_ACC,
                ACTIF_DEM_LIMI = demandeLimite.ACTIF_DEM_LIMI,
                REF_ACH_LIM = demandeLimite.REF_ACH_LIM,
                REF_CTR_DEM_LIM = refContract
            };
/**M**/
            await _unitOfWork.LimiteRepository.AddTDemLimitesync(demandeLimiteEntity);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Error during Demand Limite registration.", e);
        
    }
}

private async Task CreateIntFinanceAsync(List<T_INT_FINANCEMENT_DTO> intFinancements, int refContract)
{
    try
    {
        foreach (var intfin in intFinancements)
        {
            T_INT_FINANCEMENT int_financement = new T_INT_FINANCEMENT
            {
                DAT_DEB_VALID_INT_FIN = intfin.DAT_DEB_VALID_INT_FIN,
                DELAI_MAX_PAI_INT_FIN = intfin.DELAI_MAX_PAI_INT_FIN,
                REF_CTR_INT_FIN = refContract,
                TX_INT_MARCHE_INT_FIN = intfin.TX_INT_MARCHE_INT_FIN,
                TX_MARGE_CTR_INT_FIN = intfin.TX_MARGE_CTR_INT_FIN,
                TYP_INSTR_INT_FIN = intfin.TYP_INSTR_INT_FIN
            };

            await _unitOfWork.IntFinanceRepository.AddIntFinanceAsync(int_financement);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Error during Interest Finance registration.", e);
        
    }
}

        
        private async Task CreateDetAssAsync(T_DET_ASS_DTO detAssDto, int refContract)
        {
            try
            {
                T_DET_ASS detAssEntity = new T_DET_ASS
                {
                    REF_CTR_ASS = refContract,
                    PRIME_ASS = detAssDto.PRIME_ASS,
                    TX_COUVERTURE_ASS = detAssDto.TX_COUVERTURE_ASS,
                    DELAIS_DECALARATION_SINISTRE_ASS = detAssDto.DELAIS_DECALARATION_SINISTRE_ASS,
                    ACTIF_ASS = detAssDto.ACTIF_ASS
                };

                await _unitOfWork.DetAssRepository.AddDetAssAsync(detAssEntity);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during Det Ass registration.", e);
                
            }
        }

        private async Task   AddAdherent(int refContract, TJ_CIR individualRelationContract, int adherentRefId, string type_contrat)
        {
            try
            {
                individualRelationContract.REF_CTR_CIR = refContract;
                individualRelationContract.ID_ROLE_CIR = "ADH";
                individualRelationContract.REF_IND_CIR = adherentRefId;
                await _unitOfWork.tjcirRepository.AddTJCIRsync(individualRelationContract);

                if (type_contrat.Contains("Contrat_Reverse"))
                {
                    TJ_CIR cir2 = new TJ_CIR();
                    cir2.REF_CTR_CIR = refContract;
                    cir2.ID_ROLE_CIR = "ACH";
                    cir2.REF_IND_CIR = adherentRefId;
                    _unitOfWork.tjcirRepository.AddTJCIRsync(cir2);
                    _unitOfWork.tjcirRepository.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("   Error d enregistrement Adhérent ");
            }
        }
        
        public async ValueTask<OperationResult<bool>> Handle(AddContratCommand request,
            CancellationToken cancellationToken)
        {
            ContractDetailsDTO Contrat = request.Contrat.ContratDetail;

            try
            {
                T_CONTRAT validerContrat = new T_CONTRAT();

                validerContrat.REF_CTR = Contrat.REF_CTR;
                validerContrat.STATUT_CTR = Contrat.STATUT_CTR;
                validerContrat.REF_CTR_PAPIER_CTR = Contrat.REF_CTR_PAPIER_CTR;
                validerContrat.SERVICE_CTR = Contrat.SERVICE_CTR;
                validerContrat.TYP_CTR = Contrat.TYP_CTR;
                validerContrat.DAT_SIGN_CTR = Contrat.DAT_SIGN_CTR;
                validerContrat.DAT_DEB_CTR = Contrat.DAT_DEB_CTR;
                validerContrat.DAT_RESIL_CTR = Contrat.DAT_RESIL_CTR;
                validerContrat.DAT_PROCH_VERS_CTR = Contrat.DAT_PROCH_VERS_CTR;
                validerContrat.CA_CTR = ParseDecimalOrDefault(Contrat.CA_CTR);
                validerContrat.CA_EXP_CTR = ParseDecimalOrDefault(Contrat.CA_EXP_CTR);
                validerContrat.CA_IMP_CTR = ParseDecimalOrDefault(Contrat.CA_IMP_CTR);
                validerContrat.LIM_FIN_CTR = ParseDecimalOrDefault(Contrat.LIM_FIN_CTR);
                validerContrat.DEVISE_CTR = Contrat.DEVISE_CTR;
                validerContrat.NB_ACH_PREVU_CTR = Contrat.NB_ACH_PREVU_CTR;
                validerContrat.NB_FACT_PREVU_CTR = Contrat.NB_FACT_PREVU_CTR;
                validerContrat.NB_AVOIRS_PREVU_CTR = Contrat.NB_AVOIRS_PREVU_CTR;
                validerContrat.NB_REMISES_PREVU_CTR = Contrat.NB_REMISES_PREVU_CTR;
                validerContrat.DELAI_MOYEN_REG_CTR = Contrat.DELAI_MOYEN_REG_CTR;
                validerContrat.DELAI_MAX_REG_CTR = Contrat.DELAI_MAX_REG_CTR;
                validerContrat.FACT_REG_CTR = Contrat.FACT_REG_CTR;
                validerContrat.DERN_MONT_DISP_2 = ParseDecimalOrDefault(Contrat.DERN_MONT_DISP_2);
                validerContrat.MIN_COMM_FACT = ParseDecimalOrDefault(Contrat.MIN_COMM_FACT);
                validerContrat.IS_NOTIFIED = Contrat.IS_NOTIFIED;
                validerContrat.OLD_STATUT_CTR = Contrat.OLD_STATUT_CTR;
                validerContrat.DAT_CREATION_CTR = DateTime.Now;
                validerContrat.RESP_CTR_1 = Contrat.RESP_CTR_1;
                validerContrat.RESP_CTR_2 = Contrat.RESP_CTR_2;
            await _unitOfWork.ContratRepository.AddContratAsync(validerContrat);
            await _unitOfWork.CommitAsync();
            T_CONTRAT ctrCreated = await _unitOfWork.ContratRepository.GetContratByRefCtrPapier(Contrat.REF_CTR_PAPIER_CTR);
            await CreateFraisDiversAsync(request.Contrat.fraisDivers, ctrCreated.REF_CTR);
            await CreateFondGarantieAsync(request.Contrat.tFondGaranties, ctrCreated.REF_CTR); 
            await CreateCommFactoringAsync(request.Contrat.commFactorings, ctrCreated.REF_CTR);
            await AddAdherent(ctrCreated.REF_CTR,request.Contrat.individualRelationContract,request.Contrat.refAdh,request.Contrat.ContratDetail.TYP_CTR );
            await CreateFraisPaiementAsync(request.Contrat.fraisPaiements, ctrCreated.REF_CTR);
            await CreateDemandeLimiteAsync(request.Contrat.tDemLimites, ctrCreated.REF_CTR); 
            await CreateIntFinanceAsync(request.Contrat.tIntFinancements, ctrCreated.REF_CTR); 
            await CreateDetAssAsync(request.Contrat.tDetAss, ctrCreated.REF_CTR); 
            await _unitOfWork.CommitAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return OperationResult<bool>.SuccessResult(true);
        }
    }
}
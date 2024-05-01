using AutoMapper;
using CleanArc.Application.Contracts.Persistence;
using CleanArc.Application.Models.Common;
using CleanArc.Domain.DTO;
using Mediator;
using Exception = System.Exception;

namespace CleanArc.Application.Features.Contrat.Commands.UpdateContratCommand
{
    public class UpdateContratCommandHandler : IRequestHandler<UpdateContratCommand, OperationResult<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        private decimal ParseDecimalOrDefault(string value)
        {
            decimal result;
            if (decimal.TryParse(value, out result))
            {
                return result;
            }

            return 0;
        }

        public UpdateContratCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        
        
        private async Task UpdateDemandeLimiteAsync(List<T_DEM_LIMITE_DTO> demandeLimites, int refContract)
        {
            try
            {
                foreach (var demandeLimite in demandeLimites)
                {
                    var currentDemandeLimite = await _unitOfWork.DemandeLimiteRepository.GetDemandeLimiteByRefCtrAndType(refContract, demandeLimite.TYP_DEM_LIM);
                    if (currentDemandeLimite != null)
                    {
                        currentDemandeLimite.TYP_DEM_LIM = demandeLimite.TYP_DEM_LIM;
                        currentDemandeLimite.DAT_DEM_LIM = demandeLimite.DAT_DEM_LIM;
                        currentDemandeLimite.SORT_DEM_LIM = demandeLimite.SORT_DEM_LIM;
                        currentDemandeLimite.MONT_DEM_LIM = demandeLimite.MONT_DEM_LIM;
                        currentDemandeLimite.DEVISE = demandeLimite.DEVISE;
                        currentDemandeLimite.DATLIM_DEM_LIM = demandeLimite.DATLIM_DEM_LIM;
                        currentDemandeLimite.DECISION_LIM = demandeLimite.DECISION_LIM;
                        currentDemandeLimite.MONT_ACC = demandeLimite.MONT_ACC;
                        currentDemandeLimite.MONT_LIM_ACH_ADH = demandeLimite.MONT_LIM_ACH_ADH;
                        currentDemandeLimite.DAT_ANNUL_DEM_LIM = demandeLimite.DAT_ANNUL_DEM_LIM;
                        currentDemandeLimite.DELAIS_DEM_LIM = demandeLimite.DELAIS_DEM_LIM;
                        currentDemandeLimite.MODE_PAY_DEM_LIM = demandeLimite.MODE_PAY_DEM_LIM;
                        currentDemandeLimite.MODE_PAY_ACC = demandeLimite.MODE_PAY_ACC;
                        currentDemandeLimite.ACTIF_DEM_LIMI = demandeLimite.ACTIF_DEM_LIMI;
                        currentDemandeLimite.REF_ACH_LIM = demandeLimite.REF_ACH_LIM;

                        await _unitOfWork.DemandeLimiteRepository.UpdateDemandeLimiteAsync(currentDemandeLimite.REF_CTR_DEM_LIM, currentDemandeLimite);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during update of Demand Limite.", e);
                // Gestion de l'erreur
            }
        }

        
        
        private async Task UpdateFraisPaiementAsync(List<T_FRAIS_PAIEMENT_DTO> fraisPaiements, int refContract)
        {
            try
            {
                foreach (var fraisPaiement in fraisPaiements)
                {
                    var currentFraisPaiement = await _unitOfWork.FraisPaiementRepository.GetFraisPaiementByRefCtrAndType(refContract, fraisPaiement.TYP_FRAIS_PAIE);
                    if (currentFraisPaiement != null)
                    {
                        currentFraisPaiement.TYP_FRAIS_PAIE = fraisPaiement.TYP_FRAIS_PAIE;
                        currentFraisPaiement.MONT_PAR_INSTR_FRAIS_PAIE = fraisPaiement.MONT_PAR_INSTR_FRAIS_PAIE;
                        currentFraisPaiement.LIB_FRAIS_PAIE = fraisPaiement.LIB_FRAIS_PAIE;
                        currentFraisPaiement.REF_CTR_FRAIS_PAIE = refContract;

                        await _unitOfWork.FraisPaiementRepository.UpdateFraisPaiementAsync(currentFraisPaiement.REF_CTR_FRAIS_PAIE, currentFraisPaiement);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during update of Payment Fees.", e);
                // Gestion de l'erreur
            }
        }

        
        private async Task UpdateCommFactoringAsync(T_COMM_FACTORING_DTO commFactoring, int refContract)
        {
            try
            {
                var currentCommFactoring = await _unitOfWork.FactoringCommissionRepository.GetCommFactoringByRefCtrAndType(refContract, commFactoring.TYP_COMM_FACTORING);
                if (currentCommFactoring != null)
                {
                    currentCommFactoring.TYP_COMM_FACTORING = commFactoring.TYP_COMM_FACTORING;
                    currentCommFactoring.TX_COMM_FACTORING = commFactoring.TX_COMM_FACTORING;
                    currentCommFactoring.MONT_MIN_DOC_COMM_FACTORING = commFactoring.MONT_MIN_DOC_COMM_FACTORING;
                    currentCommFactoring.MONT_MIN_CTR_COMM_FACTORING = commFactoring.MONT_MIN_CTR_COMM_FACTORING;
                    currentCommFactoring.REF_CTR_COMM_FACTORING = refContract;

                    await _unitOfWork.FactoringCommissionRepository.UpdateFactoringCommissionAsync(currentCommFactoring.REF_CTR_COMM_FACTORING, currentCommFactoring);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during update of Comm Factoring.", e);
                // Gestion de l'erreur
            }
        }
        
        
        private async Task UpdateFondGarantieAsync(List<T_FOND_GARANTIE_DTO> fonds, int refContract)
        {
            try
            {
                foreach (var fond in fonds)
                {
                    var currentFond = await _unitOfWork.FondGarantieRepository.GetFondGarantieByRefCtrAndType(refContract, fond.TYP_FDG);
                    if (currentFond != null)
                    {
                        currentFond.TYP_FDG = fond.TYP_FDG;
                        currentFond.LIB_FDG = fond.LIB_FDG;
                        currentFond.TX_FDG = fond.TX_FDG;
                        currentFond.MONT_MAX_FDG = fond.MONT_MAX_FDG;
                        currentFond.MONT_MIN_FDG = fond.MONT_MIN_FDG;
                        currentFond.TYP_DOC_REMIS_FDG = fond.TYP_DOC_REMIS_FDG;

                        await _unitOfWork.FondGarantieRepository.UpdateFondGarantieAsync(currentFond.REF_CTR_FDG, currentFond);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during update of Fond Garantie.", e);
            }
        }

        
        
        private async Task UpdateFraisDiversAsync(List<T_FRAIS_DIVERS_DTO> fraisDivers, int refContract)
        {
            try
            {
                foreach (var fraisDiver in fraisDivers)
                {
                    var currentFin = await _unitOfWork.FraisDiversRepository.GetFraisDiversByRefCtrAndType(refContract, fraisDiver.TYP_FRAIS_DIVERS);
                    if (currentFin != null)
                    {
                        currentFin.LIB_FRAIS_DIVERS = fraisDiver.LIB_FRAIS_DIVERS;
                        currentFin.MONT_PAR_UNIT_FRAIS_DIVERS = ParseDecimalOrDefault(fraisDiver.MONT_PAR_UNIT_FRAIS_DIVERS);
                        currentFin.REF_CTR_FRAIS_DIVERS = refContract;
                        currentFin.TYP_FRAIS_DIVERS = fraisDiver.TYP_FRAIS_DIVERS;
                
                        await _unitOfWork.FraisDiversRepository.UpdateFraisDiversAsync(currentFin.REF_CTR_FRAIS_DIVERS, currentFin);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error lors de la mise à jour des Frais divers.", e);
            }
        }
        
        /*private async Task UpdateIntFinanceAsync(List<T_INT_FINANCEMENT_DTO> intFinancements, int refContract)
        {
            try
            {
                foreach (var intfin in intFinancements)
                {
                    var existingIntFinance = await _unitOfWork.IntFinanceRepository.GetIntFinanceById(refContract); // Supposons que vous avez une méthode pour obtenir un financement par son ID

                    if (existingIntFinance != null)
                    {
                        existingIntFinance.DAT_DEB_VALID_INT_FIN = intfin.DAT_DEB_VALID_INT_FIN;
                        existingIntFinance.DELAI_MAX_PAI_INT_FIN = intfin.DELAI_MAX_PAI_INT_FIN;
                        existingIntFinance.TX_INT_MARCHE_INT_FIN = intfin.TX_INT_MARCHE_INT_FIN;
                        existingIntFinance.TX_MARGE_CTR_INT_FIN = intfin.TX_MARGE_CTR_INT_FIN;
                        existingIntFinance.TYP_INSTR_INT_FIN = intfin.TYP_INSTR_INT_FIN;

                        await _unitOfWork.IntFinanceRepository.UpdateIntFinanceAsync(existingIntFinance.REF_CTR_INT_FIN, existingIntFinance);
                    }
                    else
                    {
                        Console.WriteLine($"Interest Finance with ID  not found for update.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during Interest Finance update.", e);
                // Gestion de l'erreur
            }
        }*/

        private async Task UpdateDetAssAsync(T_DET_ASS_DTO detAssDto, int refContract)
        {
            try
            {
                var existingDetAss = await _unitOfWork.DetAssRepository.GetDetAssById(refContract);

                if (existingDetAss != null)
                {
                    existingDetAss.PRIME_ASS = detAssDto.PRIME_ASS;
                    existingDetAss.TX_COUVERTURE_ASS = detAssDto.TX_COUVERTURE_ASS;
                    existingDetAss.DELAIS_DECALARATION_SINISTRE_ASS = detAssDto.DELAIS_DECALARATION_SINISTRE_ASS;
                    existingDetAss.ACTIF_ASS = detAssDto.ACTIF_ASS;

                    await _unitOfWork.DetAssRepository.UpdateDetAssAsync(existingDetAss.REF_CTR_ASS, existingDetAss);
                }
                else
                {
                    Console.WriteLine($"Det Ass for contract with reference {refContract} not found for update.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during Det Ass update.", e);
            }
        }



        public async ValueTask<OperationResult<bool>> Handle(UpdateContratCommand request, CancellationToken cancellationToken)
        {
            var existingContrat = await _unitOfWork.ContratRepository.GetContratById(request.Contrat.Contrat.REF_CTR);

            if (existingContrat == null)
            {
                return OperationResult<bool>.FailureResult($"Contrat with id {request.Contrat.Contrat.REF_CTR} not found.");
            }

            _mapper.Map(request.Contrat, existingContrat);

            try
            {
                await _unitOfWork.ContratRepository.UpdateContratAsync(existingContrat.REF_CTR, request.Contrat.Contrat);
                await UpdateFraisDiversAsync(request.Contrat.fraisDivers, request.Contrat.Contrat.REF_CTR);
                await UpdateFondGarantieAsync(request.Contrat.tFondGaranties, request.Contrat.Contrat.REF_CTR);
                await UpdateFraisPaiementAsync(request.Contrat.fraisPaiements, request.Contrat.Contrat.REF_CTR);
                await UpdateDemandeLimiteAsync(request.Contrat.tDemLimites, request.Contrat.Contrat.REF_CTR);
               // await UpdateIntFinanceAsync(request.Contrat.tIntFinancements, request.Contrat.Contrat.REF_CTR); 
                await UpdateDetAssAsync(request.Contrat.tDetAss, request.Contrat.Contrat.REF_CTR);
                

                return OperationResult<bool>.SuccessResult(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.FailureResult($"Error updating Contrat: {ex.Message}");
            }
        }
    }
}

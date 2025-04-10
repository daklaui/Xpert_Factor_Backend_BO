using CleanArc.Application.Contracts.Persistence;
using Moq;

namespace CleanArc.Test.Infrastructure.Identity;

public class TestUnitOfWork:IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository => new Mock<IUserRefreshTokenRepository>().Object;
    public IOrderRepository OrderRepository => new Mock<IOrderRepository>().Object;
    public IIndividualRepository IndividualRepository => new Mock<IIndividualRepository>().Object;
    public IPostalCodesRepository PostalCodesRepository => new Mock<IPostalCodesRepository>().Object;
    public IGEDRepository GEDRepository => new Mock<IGEDRepository>().Object;
    public ITMMRepository TmmRepository => new Mock<ITMMRepository>().Object;
    public IFundingRepository FundingRepository => new Mock<IFundingRepository>().Object;
    public IContactRepository contactRepository => new Mock<IContactRepository>().Object;
    public IRibRepository ribRepository => new Mock<IRibRepository>().Object;
    public IAdhAuthRepository adhAuthRepository => new Mock<IAdhAuthRepository>().Object;
    public ITjcirRepository tjcirRepository => new Mock<ITjcirRepository>().Object;
    public IimpayeRepository ImpayeRepository => new Mock<IimpayeRepository>().Object;
    public ICreditRepository CreditRepository => new Mock<ICreditRepository>().Object;
    public IDebitRepository DebitRepository => new Mock<IDebitRepository>().Object;
    public IExtraitRepository ExtraitRepository => new Mock<IExtraitRepository>().Object;
    public IAgencyBankRepository AgencyBankRepository => new Mock<IAgencyBankRepository>().Object;
    public IEncaissement EncaissementRepository => new Mock<IEncaissement>().Object;
    public ILimiteRepository LimiteRepository => new Mock<ILimiteRepository>().Object;
    public IListValRepository ListValRepository => new Mock<IListValRepository>().Object;
    public IProrogationsRepository ProrogationsRepository => new Mock<IProrogationsRepository>().Object;
    public ILitigesRepository LitigesRepository => new Mock<ILitigesRepository>().Object;
    public IRecouvrementRepository RecouvrementRepository => new Mock<IRecouvrementRepository>().Object;
    public ITJobsRepository TJobsRepository => new Mock<ITJobsRepository>().Object;
    public IContratRepository ContratRepository => new Mock<IContratRepository>().Object;
    public IFraisDiversRepository FraisDiversRepository => new Mock<IFraisDiversRepository>().Object;
    public IFactoringCommissionRepository FactoringCommissionRepository => new Mock<IFactoringCommissionRepository>().Object;
    public IFraisPaiementRepository FraisPaiementRepository => new Mock<IFraisPaiementRepository>().Object;
    public IIntFinanceRepository IntFinanceRepository => new Mock<IIntFinanceRepository>().Object;
    public IDetAssRepository DetAssRepository => new Mock<IDetAssRepository>().Object;
    public IFondGarantieRepository FondGarantieRepository => new Mock<IFondGarantieRepository>().Object;
    public IT_DET_BORD_Repository TDetBordRepository => new Mock<IT_DET_BORD_Repository>().Object;
    public ITJ_DOCUMENT_DET_BORD_Repository TjDocumentDetBordRepository => new Mock<ITJ_DOCUMENT_DET_BORD_Repository>().Object;
    public IBordereauxRepository BordereauxRepository => new Mock<IBordereauxRepository>().Object;
    public ITvaRepository TvaRepository { get; }
    public ILettrageRepository LettrageRepository { get; }
    public IActprofRepository ActprofRepository => new Mock<IActprofRepository>().Object;
    public IHistoriqueRepository HistoriqueRepository => new Mock<IHistoriqueRepository>().Object;
    public IUserRepository UserRepository { get; }

    public IGroupSocietyRepository GroupSocietyRepository => throw new NotImplementedException();

    public IT_DOC_PHYSIQUERepositroy T_DOC_PHYSIQUERepositroy => throw new NotImplementedException();

    public IT_SIGNATAIRES_DU_CONTRATRepository T_SIGNATAIRES_DU_CONTRATRepository => throw new NotImplementedException();

    public ICOMMENTRepository COMMENTRepository => throw new NotImplementedException();
    public IResoluRepository ResoluRepository { get; }
    public IRoleUser RoleUser { get; }
    public ITR_CPRepository CpRepository { get; }

    public Task BeginTransactionAsync()
    {
        throw new NotImplementedException();
    }

    public Task CommitAsync() => Task.CompletedTask;

    public Task CommitMultipleTransactionAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask RollBackAsync() => ValueTask.CompletedTask;

    public Task RollbackAsync()
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
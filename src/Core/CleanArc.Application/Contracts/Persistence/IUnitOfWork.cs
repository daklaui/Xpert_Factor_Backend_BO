namespace CleanArc.Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
        IOrderRepository OrderRepository { get; }
        IIndividualRepository IndividualRepository { get; }
        ITPostalCodesRepository TPostalCodesRepository { get; }
        ITJobsRepository TJobsRepository { get; }
        IListValueRepository ListValueRepository { get; }
        ITR_CPRepository TR_CPRepository { get; }
        IContratRepository ContratRepository { get; }
        IFraisDiversRepository FraisDiversRepository { get; }
        
        IFactoringCommissionRepository FactoringCommissionRepository { get; }
        
        Task CommitAsync();
        ValueTask RollBackAsync();
    }
}
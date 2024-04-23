namespace CleanArc.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public IIndividualRepository IndividualRepository { get; }
    public IT_DET_BORD_Repository TDetBordRepository { get; }
    ITJ_DOCUMENT_DET_BORD_Repository TjDocumentDetBordRepository { get; }
    public IBordereauxRepository BordereauxRepository { get; }
    Task CommitAsync();
    ValueTask RollBackAsync();
}
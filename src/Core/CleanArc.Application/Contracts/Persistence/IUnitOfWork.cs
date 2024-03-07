﻿namespace CleanArc.Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        public IUserRefreshTokenRepository UserRefreshTokenRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IIndividualRepository IndividualRepository { get; }
        public ITPostalCodesRepository TPostalCodesRepository { get; }
        public ITJobsRepository TJobsRepository { get; }
        public ITListValRepository TListValRepository { get; } 
        Task CommitAsync();
        ValueTask RollBackAsync();
    }
}
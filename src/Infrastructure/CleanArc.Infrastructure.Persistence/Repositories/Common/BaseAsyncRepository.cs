using System.Linq.Expressions;
using CleanArc.Application.Common;
using CleanArc.Domain.Common;
using CleanArc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

internal abstract class BaseAsyncRepository<TEntity> where TEntity:class,IEntity
{
    public readonly ApplicationDbContext DbContext;
    protected DbSet<TEntity> Entities { get; }
    protected virtual IQueryable<TEntity> Table => Entities;
    protected virtual IQueryable<TEntity> TableNoTracking => Entities.AsNoTrackingWithIdentityResolution();

    protected BaseAsyncRepository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
        Entities = DbContext.Set<TEntity>(); // City => Cities
    }

    protected virtual async Task<List<TEntity>> ListAllAsync()
    {
        return await Entities.ToListAsync();
    }

    protected virtual async Task AddAsync(TEntity entity)
    { 
        await Entities.AddAsync(entity);
           
    }

    protected virtual async Task UpdateAsync(TEntity entity)
    {
        DbContext.Entry(entity).State = EntityState.Modified;
        await DbContext.SaveChangesAsync();
    }

    protected virtual async Task DeleteAsync(Expression<Func<TEntity,bool>> deleteExpression)
    {
        await Entities.Where(deleteExpression).ExecuteDeleteAsync();
    }

    
}
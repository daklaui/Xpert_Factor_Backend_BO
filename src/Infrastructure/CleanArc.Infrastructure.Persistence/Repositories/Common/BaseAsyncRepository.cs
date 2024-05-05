﻿using System.Linq.Expressions;
using CleanArc.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CleanArc.Infrastructure.Persistence.Repositories.Common;

public abstract class BaseAsyncRepository<TEntity> where TEntity:class,IEntity
{
    public readonly ApplicationDbContext DbContext;
    protected DbSet<TEntity> Entities { get; }
    protected virtual IQueryable<TEntity> Table => Entities;
    protected virtual IQueryable<TEntity> TableNoTracking => Entities.AsNoTrackingWithIdentityResolution();

    protected BaseAsyncRepository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
        Entities = DbContext.Set<TEntity>(); 
    }

    protected virtual async Task<List<TEntity>> ListAllAsync()
    {
        return await Entities.ToListAsync();
    }

    protected virtual async Task AddAsync(TEntity entity)
    { 
        await Entities.AddAsync(entity);
           
    }

    protected virtual async Task UpdateAsync(
        Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> updateExpression)
    {
        await Entities.ExecuteUpdateAsync(updateExpression);
    }
    
    protected virtual async Task UpdateAsync1(TEntity entity)
    {
        DbContext.Entry(entity).State = EntityState.Modified;
        await DbContext.SaveChangesAsync();
    }

    protected virtual async Task DeleteAsync(Expression<Func<TEntity,bool>> deleteExpression)
    {
        await Entities.Where(deleteExpression).ExecuteDeleteAsync();
    }
}

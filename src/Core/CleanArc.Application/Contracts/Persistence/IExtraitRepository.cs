using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IExtraitRepository
{
    public Task addExtraitAsync(T_EXTRAIT extrait); 
}

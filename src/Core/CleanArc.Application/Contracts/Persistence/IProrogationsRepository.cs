using CleanArc.Domain.Entities;

namespace CleanArc.Application.Contracts.Persistence;

public interface IProrogationsRepository
{
    Task AddProrogation(T_PROROGATION prorogation, DateTime echeanceFacturePro);

}
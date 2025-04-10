using CleanArc.Application.Common;
using CleanArc.Domain.Entities.Profil;

namespace CleanArc.Application.Contracts.Persistence;

public interface IProfilRepository
{
            Task AddProfileAsync(Profil profil);
            Task<PagedList<Profil>> GetAllProfilesAsync(PaginationParams paginationParams);
            Task<bool> EditProfileAsync(int idProfile, Profil profil);
            Task<Profil> GetProfileByIdAsync(int idProfile);
}
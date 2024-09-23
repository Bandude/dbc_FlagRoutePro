using dbc_FlagRoutePro.Entities;

namespace dbc_FlagRoutePro.Interfaces
{
    public interface IFlagSeasonService
    {

        Task AddAsync(FlagSeason item);
        Task DeleteAsync(int id);
        Task UpdateAsync(FlagSeason item);
        Task<FlagSeason> GetByIdAsync(int id);
        Task<IEnumerable<FlagSeason>> GetAllAsync();

    }
}
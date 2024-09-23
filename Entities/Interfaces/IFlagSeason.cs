using dbc_FlagRoutePro.Entities;

public interface IFlagSeason
{
    Task AddAsync(FlagSeason item);
    Task DeleteAsync(int id);
    Task UpdateAsync(FlagSeason item);
    Task<FlagSeason> GetByIdAsync(int id);
    Task<IEnumerable<FlagSeason>> GetAllAsync();
    void LogDates();
}
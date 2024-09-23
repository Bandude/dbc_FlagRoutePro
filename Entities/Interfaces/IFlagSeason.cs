using dbc_FlagRoutePro.Entities;

namespace dbc_FlagRoutePro.Interfaces
{
    public interface IFlagSeason
    {
        int Id { get; set; }
        string Name { get; set; }
        int SubscriptionTypeId { get; set; }
        DateTime StartingDate { get; set; }
        DateTime EndingDate { get; set; } // Ensure this is defined in the interface as well

        Task AddAsync(FlagSeason item);
        Task DeleteAsync(int id);
        Task UpdateAsync(FlagSeason item);
        Task<FlagSeason> GetByIdAsync(int id);
        Task<IEnumerable<FlagSeason>> GetAllAsync();
        void LogDates();
    }
}
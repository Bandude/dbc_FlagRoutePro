
using dbc_FlagRoutePro.Interfaces;

namespace dbc_FlagRoutePro.Entities
{
    public class FlagRouteSeasonDates
    {
        public int Id { get; set; }
        
        public string Name { get; set; } 
  
        public DateTime FlagRouteDate { get; set; } = DateTime.Now;

        public required FlagSeason FlagSeason { get; set; }
    }
}

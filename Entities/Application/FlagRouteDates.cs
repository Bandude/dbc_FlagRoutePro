using dbc_FlagRoutePro.Entities.Interfaces;

namespace dbc_FlagRoutePro.Entities
{
    public class FlagRouteSeasonDates
    {
        public int Id { get; set; }
        
        public string Name { get; set; } 
  
        public DateTime FlagRouteDate { get; set; } = DateTime.Now;

        public IFlagSeason FlagSeason { get; set; }
    }
}

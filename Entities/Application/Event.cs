namespace dbc_FlagRoutePro.Entities
{

    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public DateTime EventDate { get; set; }
        public int FlagRouteId { get; set; }
        public FlagRoute FlagRoute { get; set; }
        public List<Volunteer> AssignedVolunteers { get; set; } = new List<Volunteer>();
        public override string ToString()
        {
            return $"{Name} on {EventDate.ToShortDateString()}";
        }
    }

}

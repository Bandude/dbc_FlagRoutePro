namespace dbc_FlagRoutePro.Entities
{




    public class FlagRoute
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public List<RouteStop> Stops { get; set; } = new List<RouteStop>();
        public override string ToString()
        {
            return Name;
        }
    }



}

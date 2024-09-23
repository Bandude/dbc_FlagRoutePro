namespace dbc_FlagRoutePro.Entities
{

    public class RouteStop
    {
        public int Id { get; set; }
        public int Order { get; set; } // Example: 1, 2, 3...
        public int FlagCount { get; set; }
        public string Description { get; set; }
        public int FlagRouteId { get; set; }
        public FlagRoute FlagRoute { get; set; }
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
        public override string ToString()
        {
            return $"Stop Order: {Order}, Address: {Subscription.Address}";
        }
    }

}

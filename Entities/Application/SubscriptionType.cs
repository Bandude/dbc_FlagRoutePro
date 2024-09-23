namespace dbc_FlagRoutePro.Entities
{

    public class SubscriptionType
    {
        public int Id { get; set; }
        public string Name { get; set; } // Example: "US Flags", "TTU Flags"
        public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();

        public override string ToString()
        {
            return Name;
        }
    }
}

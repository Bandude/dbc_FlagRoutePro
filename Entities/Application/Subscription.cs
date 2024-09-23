namespace dbc_FlagRoutePro.Entities
{


    public class Subscription
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; } // When the subscription starts
        public bool IsActive { get; set; } = true; // Active status
        public int SubscriptionTypeId { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public override string ToString()
        {
            return $"Subscription: {SubscriptionType?.Name}, Active: {IsActive}";
        }
    }


}

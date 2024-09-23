using System.Net;

namespace dbc_FlagRoutePro.Entities
{

    public class Address
    {
        public int Id { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();
        public override string ToString()
        {
            return $"{Line1}, {Line2}, {City}, {State}, {ZipCode}";
        }
    }
}




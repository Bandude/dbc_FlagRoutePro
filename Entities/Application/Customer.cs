using System.Net;

namespace dbc_FlagRoutePro.Entities
{


    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"{FullName}, {Email}, {Phone}";
        }
    }




}

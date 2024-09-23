
namespace dbc_FlagRoutePro.Entities
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"{FullName}, {Email}, {Phone}";
        }
    }
}

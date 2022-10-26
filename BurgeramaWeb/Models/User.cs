using System.Xml.Serialization;

namespace BurgeramaWeb.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Postal { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

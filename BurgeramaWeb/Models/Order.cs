namespace BurgeramaWeb.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int PrepTime { get; set; }
        public int ShipTime { get; set; }
        public int TotalTime { get; set; }
        public double TotalSum { get; set; }
        public string Status { get; set; }

        public User User { get; set; }

        public Driver Driver { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}

namespace BurgeramaWeb.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int OpenOrders { get; set; }
        public int WorkLoad { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

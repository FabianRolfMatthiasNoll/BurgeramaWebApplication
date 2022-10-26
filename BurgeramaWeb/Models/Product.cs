namespace BurgeramaWeb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int CategoryID { get; set; }
        public int PrepTime { get; set; }
        public double Price { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}

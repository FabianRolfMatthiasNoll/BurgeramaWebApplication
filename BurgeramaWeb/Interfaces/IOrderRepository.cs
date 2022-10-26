using BurgeramaWeb.Models;

namespace BurgeramaWeb.Interfaces
{
    public interface IOrderRepository
    {
        ICollection<Order> GetOrders();
    }
}

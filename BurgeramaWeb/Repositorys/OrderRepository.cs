using BurgeramaWeb.Data;
using BurgeramaWeb.Interfaces;
using BurgeramaWeb.Models;

namespace BurgeramaWeb.Repositorys
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Order> GetOrders()
        {
            return _context.Orders.OrderBy(o => o.Id).ToList();
        }
    }
}

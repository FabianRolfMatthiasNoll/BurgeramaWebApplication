using BurgeramaWeb.Data;
using BurgeramaWeb.Models;
using System.Diagnostics.Metrics;

namespace BurgeramaWeb
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.OrderProducts.Any())
            {
                var orderProducts = new List<OrderProduct>()
                {
                    new OrderProduct()
                    {
                        Order = new Order()
                        {
                            PrepTime = 5,
                            ShipTime = 20,
                            TotalTime = 25,
                            TotalSum = 7.99,
                            Status = "Preperation",

                            User = new User()
                            {
                                Email = "Fabian.Noll@gmail.com",
                                Password = "hello",
                                City = "Tuttlingen",
                                Street = "Neuhauser Straße 71",
                                Postal = "78532"
                            },

                            Driver = new Driver()
                            {
                                Name = "Gustavo Fring",
                                Capacity = 4,
                                OpenOrders = 1,
                                WorkLoad = 3,
                            }
                        },
                        Product = new Product()
                        {
                            Name = "Cheeseburger",
                            Category = "Food",
                            CategoryID = 1,
                            Price = 7.99,
                            PrepTime = 5,
                        }
                    }
                };
                dataContext.OrderProducts.AddRange(orderProducts);
                dataContext.SaveChanges();
            }
        }
    }
}

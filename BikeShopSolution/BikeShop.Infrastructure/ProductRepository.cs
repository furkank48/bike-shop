using BikeShop.Application;
using BikeShop.Domain;

namespace BikeShop.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Dağ Bisikleti", Category = "Bisiklet", Price = 5000, Stock = 10 },
                new Product { Id = 2, Name = "Yol Bisikleti", Category = "Bisiklet", Price = 7000, Stock = 5 },
                new Product { Id = 3, Name = "Bisiklet Zinciri", Category = "Parça", Price = 150, Stock = 50 }
            };
        }
    }
}

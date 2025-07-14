using System.Collections.Generic;
using BikeShop.Domain;

namespace BikeShop.Application
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
        bool DeleteProduct(int id);
        bool UpdateProduct(int id, Product product);



    }
}

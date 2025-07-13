using BikeShop.Application;
using BikeShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeShop.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        // Ürünleri hafızada tutan liste
        private readonly List<Product> _products;

        // Constructor → başlangıç ürünlerini ekliyoruz
        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Dağ Bisikleti", Category = "Bisiklet", Price = 5000, Stock = 10 },
                new Product { Id = 2, Name = "Yol Bisikleti", Category = "Bisiklet", Price = 7000, Stock = 5 },
                new Product { Id = 3, Name = "Bisiklet Zinciri", Category = "Parça", Price = 150, Stock = 50 }
            };
        }

        // Tüm ürünleri döner
        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        // Yeni ürün ekler
        public void AddProduct(Product product)
        {
            if (product.Id == 0)
            {
                product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
            }
            _products.Add(product);
            Console.WriteLine($"Ürün eklendi: {product.Name}");
        }

        // Ürün siler
        public bool DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return false;

            _products.Remove(product);
            Console.WriteLine($"Ürün silindi: {product.Name}");
            return true;
        }
    }
}

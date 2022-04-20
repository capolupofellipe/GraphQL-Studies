using System;
using System.Collections.Generic;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class ProductService : IProduct
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product() {Id = 0, Name = "Product 1", Price = 10},
            new Product() { Id = 1, Name = "Product 2", Price = 20}
        };

        public Product Add(Product product)
        {
            _products.Add(product);
            return product;
        }

        public void Delete(int id)
        {
            _products.RemoveAt(id);
        }

        public Product Get(int id)
        {
            return _products.Find(x => x.Id == id);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product Update(int id, Product product)
        {
            _products[id] = product;
            return product;
        }
    }
}

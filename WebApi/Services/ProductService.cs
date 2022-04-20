using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class ProductService : IProduct
    {
        private readonly GraphQLDbContext _dbContext;

        public ProductService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product Add(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public void Delete(int id)
        {
            var existingProduct =_dbContext.Products.Find(id);

            if (existingProduct is null)
                return;

            _dbContext.Products.Remove(existingProduct);
            _dbContext.SaveChanges();
        }

        public Product Get(int id)
        {
            return _dbContext.Products.Find(id);
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public Product Update(int id, Product product)
        {
            var existingProduct = _dbContext.Products.Find(id);
            if (existingProduct is null)
                return null;

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            _dbContext.Products.Update(existingProduct);
            _dbContext.SaveChanges();
            return existingProduct;
        }
    }
}

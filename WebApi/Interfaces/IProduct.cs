using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IProduct
    {
        List<Product> GetAll();
        Product Get(int id);
        Product Add(Product product);
        Product Update(int id, Product product);
        void Delete(int id);
    }
}

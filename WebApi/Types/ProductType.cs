using GraphQL.Types;
using WebApi.Models;

namespace WebApi.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Price);
        }
    }
}

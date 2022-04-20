using GraphQL.Types;
using WebApi.Mutations;
using WebApi.Query;

namespace WebApi.Schemas
{
    public class ProductSchema : Schema
    {
        public ProductSchema(ProductQuery productQuery, ProductMutation productMutation)
        {
            Query = productQuery;
            Mutation = productMutation;
        }
    }
}

using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Types;

namespace WebApi.Mutations
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProduct productService)
        {
            Field<ProductType>("createProduct", arguments: new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" }),
                resolve: context =>
                {
                    return productService.Add(context.GetArgument<Product>("product"));
                });

            Field<ProductType>("updateProduct",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" },
                new QueryArgument<ProductInputType> { Name = "product" }),
                resolve: context =>
                {
                    var argId = context.GetArgument<int>("id");
                    var argProduct = context.GetArgument<Product>("product");
                    return productService.Update(argId, argProduct);
                });

            Field<StringGraphType>("deleteProduct",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    var argId = context.GetArgument<int>("id");                    
                    productService.Delete(argId);
                    return "Product deleted";
                });
        }
    }
}

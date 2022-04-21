using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebApi.Query;

namespace WebApi.Schemas
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider): base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
        }
    }
}

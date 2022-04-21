using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebApi.Query;
using WebApi.Services;

namespace WebApi.Schemas
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider): base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}

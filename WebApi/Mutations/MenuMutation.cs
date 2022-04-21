using GraphQL;
using GraphQL.Types;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Types;

namespace WebApi.Mutations
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuService menuService)
        {
            Field<MenuType>("addMenu",
                arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),
                resolve: context =>
                {
                    return menuService.Add(context.GetArgument<Menu>("menu"));
                });
        }
    }
}

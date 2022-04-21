using GraphQL;
using GraphQL.Types;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Types;

namespace WebApi.Mutations
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenuService subMenuService)
        {
            Field<SubMenuType>("addSubMenu",
                arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }),
                resolve: context =>
                {
                    return subMenuService.Add(context.GetArgument<SubMenu>("subMenu"));
                });
        }
    }
}

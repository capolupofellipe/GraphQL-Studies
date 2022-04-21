using GraphQL;
using GraphQL.Types;
using WebApi.Interfaces;
using WebApi.Types;

namespace WebApi.Query
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenuService subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("subMenus", resolve: context => { return subMenuService.GetAll(); });
            Field<ListGraphType<SubMenuType>>("subMenuByMenu",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "menuId" }),
                resolve: context => { return subMenuService.GetByMenu(context.GetArgument<int>("id")); });
        }
    }
}

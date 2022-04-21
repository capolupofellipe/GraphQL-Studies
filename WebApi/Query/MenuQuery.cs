using GraphQL.Types;
using WebApi.Interfaces;
using WebApi.Types;

namespace WebApi.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuService menuService)
        {
            Field<ListGraphType<MenuType>>("menus", resolve: context => { return menuService.GetAll(); });
        }
    }
}

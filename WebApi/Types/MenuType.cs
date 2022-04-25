using GraphQL.Types;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Types
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenuService subMenuService)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.ImageUrl);
            Field<ListGraphType<SubMenuType>>("subMenus", resolve: context => { return subMenuService.GetByMenu(context.Source.Id); });
        }
    }
}

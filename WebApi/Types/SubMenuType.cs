using GraphQL.Types;
using WebApi.Models;

namespace WebApi.Types
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Price);
            Field(x => x.ImageUrl);
            Field(x => x.Description);
            Field(x => x.MenuId);
        }
    }
}

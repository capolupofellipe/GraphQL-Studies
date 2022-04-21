using GraphQL.Types;
using WebApi.Models;

namespace WebApi.Types
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.ImageUrl);
        }
    }
}

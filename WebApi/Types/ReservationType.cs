using GraphQL.Types;
using WebApi.Models;

namespace WebApi.Types
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Phone);
            Field(x => x.Email);
            Field(x => x.TotalPeople);
            Field(x => x.Date);
        }
    }
}

using GraphQL;
using GraphQL.Types;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Types;

namespace WebApi.Mutations
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservationService reservationService)
        {
            Field<ReservationType>("addReservation",
                arguments: new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" }),
                resolve: context =>
                {
                    return reservationService.Add(context.GetArgument<Reservation>("reservation"));
                });
        }
    }
}

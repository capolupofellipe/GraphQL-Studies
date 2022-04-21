﻿using GraphQL;
using GraphQL.Types;
using WebApi.Interfaces;
using WebApi.Types;

namespace WebApi.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationService reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservations", resolve: context => { return reservationService.GetAll(); });
        }
    }
}

using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Types
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("phone");
            Field<StringGraphType>("email");
            Field<DateTimeGraphType>("date");
            Field<IntGraphType>("totalPeople");
        }
    }
}

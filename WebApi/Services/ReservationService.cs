using System.Collections.Generic;
using System.Linq;
using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Services
{
    public class ReservationService : IReservationService
    {
        private readonly GraphQLDbContext _dbContext;

        public ReservationService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Reservation Add(Reservation reservation)
        {
            _dbContext.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetAll()
        {
            return _dbContext.Reservations.ToList();
        }
    }
}

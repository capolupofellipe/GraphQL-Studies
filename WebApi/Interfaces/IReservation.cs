using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IReservationService
    {
        List<Reservation> GetAll();        
        Reservation Add(Reservation reservation);
    }
}
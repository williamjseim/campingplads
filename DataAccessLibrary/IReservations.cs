using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IReservations
    {
        Task<List<Lots>> GetReservation();
        Task InsertReservation(Reservations reservation);
    }
}
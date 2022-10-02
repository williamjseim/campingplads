using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IReservations
    {
        Task<List<LotsModel>> GetReservation();
        Task InsertReservation(LotsModel reservation);
    }
}
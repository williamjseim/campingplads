using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IReservations
    {
        Task<List<LotsModel>> GetLot();
        Task InsertLot(LotsModel reservation);
    }
}
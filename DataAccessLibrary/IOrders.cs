using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IOrders
    {
        Task<List<OrderModel>> GetTable();
        Task InsertRow(OrderModel data);
    }
}
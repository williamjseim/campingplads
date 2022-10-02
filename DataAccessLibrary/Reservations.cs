using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class Reservations : IReservations
    {
        private readonly ISqlDataAccess _ReservationDB;

        public Reservations(ISqlDataAccess ReservationDB)
        {
            _ReservationDB = ReservationDB;
        }

        public Task<List<LotsModel>> GetLot()
        {
            string sql = "select rented,lotSize from dbo.lots";

            return _ReservationDB.loadData<LotsModel, dynamic>(sql, new { });
        }

        public Task InsertLot(LotsModel reservation)
        {
            string sql = @"insert into dbo.lots(rented,lotSize)
                           values(@Rented,@lotsize);";

            return _ReservationDB.SaveData(sql, reservation);
        }
    }
}

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
        private readonly ISqlDataAccess _db;

        public Reservations(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Lots>> GetReservation()
        {
            string sql = "select * from dbo.lots";

            return _db.loadData<Lots, dynamic>(sql, new { });
        }

        public Task InsertReservation(Reservations reservation)
        {
            string sql = @"insert into dbo.lots(rented, lotsize)
                           values(@rented,@lotsize);";
            return _db.SaveData(sql, reservation);
        }
    }
}

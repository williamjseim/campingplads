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

        public Task<List<LotsModel>> GetReservation()
        {
            string sql = "select * from dbo.lots";

            return _db.loadData<LotsModel, dynamic>(sql, new { });
        }

        public Task InsertReservation(Reservations reservation)
        {
            string sql = @"insert into dbo.lots(rented, lotsize)
                           values(@rented,@lotsize);";

            Console.WriteLine(sql.ToString() + " " + reservation.ToString());
            return _db.SaveData(sql, reservation);
        }
    }
}

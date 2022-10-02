using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class Orders : IOrders
    {
        private readonly ISqlDataAccess _orderDB;

        public Orders(ISqlDataAccess orderDB)
        {
            _orderDB = orderDB;
        }

        public Task<List<OrderModel>> GetTable()//get everything in one table from the database
        {
            string sql = "select * from dbo.orders";

            return _orderDB.loadData<OrderModel, dynamic>(sql, new { });
        }

        public Task InsertRow(OrderModel data)//insert data into sql database
        {
            string sql = @"insert into dbo.orders(lotID,first_name,last_name,phone_number,email)
                           values(@lotID,@first_name,@last_name,@phone_number,@email);";

            return _orderDB.SaveData(sql, data);
        }
    }
}

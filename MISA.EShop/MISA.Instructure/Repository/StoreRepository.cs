using Dapper;
using MISA.Core.Entities;
using MISA.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Instructure.Repository
{
    public class StoreRepository : BaseRepository, IStoreRepository
    {
        /// <summary>
        /// Lấy thông tin cửa hàng theo mã cửa hàng
        /// </summary>
        /// <param name="storeCode"></param>
        /// <returns></returns>
        public Store GetStoreByStoreCode(string storeCode)
        {
            var sqlCommnad = $"SELECT  StoreCode  FROM Store WHERE StoreCode = '{storeCode}' ";
            var store = _dbConnection.Query<Store>(sqlCommnad, commandType: System.Data.CommandType.Text).FirstOrDefault();
            return store;
        }
    }
}

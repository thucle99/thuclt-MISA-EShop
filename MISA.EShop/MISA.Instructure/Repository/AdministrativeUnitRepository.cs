using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MISA.Core.Entities;
using MISA.Core.Interface;

namespace MISA.Instructure.Repository
{
    public class AdministrativeUnitRepository :BaseRepository, IAdministrativeUnitRepository
    {
        public AdministrativeUnit GetCityById(string storeCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lấy thông tin đơn vị hành chính theo mã đơn vị hành chính
        /// </summary>
        /// <param name="customerCode"></param>
        /// <returns></returns>
        public Store GetCustomerByCustomerCode(string customerCode)
        {
            var sqlCommnad = $"SELECT  CustomerCode  FROM Customer WHERE CustomerCode = '{customerCode}' ";
            var customer = _dbConnection.Query<Store>(sqlCommnad, commandType: System.Data.CommandType.Text).FirstOrDefault();
            return customer;
        }
    }
}

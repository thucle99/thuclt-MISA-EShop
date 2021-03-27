using Dapper;
using MISA.Core.Entities;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public class CustomerGroupService
    {
        // <summary>
        /// Lấy thông tin nhóm khách hàng
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerGroup> GetCustomerGroups()
        {
            string connectionString = "Host = 47.241.69.179; " +
                "Port  = 3306; " +
                "Database = MF750_LTThuc_CukCuk; " +
                "User Id = dev; Password = 12345678 ";

            IDbConnection dbConnection = new MySqlConnection(connectionString);
            var customers = dbConnection.Query<CustomerGroup>("Proc_GetCustomerGroups", commandType: CommandType.StoredProcedure);
            return customers;

        }

        /// <summary>
        /// Lấy thông tin nhóm khách hàng theo id
        /// </summary>
        /// <returns></returns>
        public CustomerGroup GetCustomerGroupById(Guid customerGroupId)
        {
            string connectionString = "Host = 47.241.69.179; " +
                "Port  = 3306; " +
                "Database = MF750_LTThuc_CukCuk; " +
                "User Id = dev; Password = 12345678 ";

            var dynamicParams = new DynamicParameters();
            dynamicParams.Add("@CustomerGroupId", customerGroupId.ToString());
            IDbConnection dbConnection = new MySqlConnection(connectionString);

            var customerGroup = dbConnection.Query<CustomerGroup>($"Proc_GetCustomerGroupById",
                param: dynamicParams,
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            return customerGroup;
        }

        /// <summary>
        /// Thêm nhóm khách hàng
        /// </summary>
        /// <param name="customer"></param>
        public void InsertCustomerGroup(CustomerGroup customerGroup)
        {
            string connectionString = "Host = 47.241.69.179; " +
                "Port  = 3306; " +
                "Database = MF750_LTThuc_CukCuk; " +
                "User Id = dev; Password = 12345678 ";

            //var dynamicParams = new DynamicParameters();
            //dynamicParams.Add("@CustomerId", customerId.ToString());

            IDbConnection dbConnection = new MySqlConnection(connectionString);
            var res = dbConnection.Query($"Proc_InsertCustomerGroup",
                customerGroup,
                    commandType: CommandType.StoredProcedure).FirstOrDefault();

            //Query lấy thông tin của khách hàng 
        }
    }
}

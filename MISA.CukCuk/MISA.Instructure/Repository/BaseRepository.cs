﻿using Dapper;
using MISA.Core.Interface;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Instructure.Repository
{
    public class BaseRepository : IBaseRepository
    {
        // connectionString là trường, không thể thay đổi giá trị
        // _ thể hiện biến private
        protected string _connectionString = "Host = 47.241.69.179; " +
               "Port  = 3306; " +
               "Database = MF750_LTThuc_EShop; " +
               "User Id = dev; Password = 12345678 ";
        protected IDbConnection _dbConnection;
        public BaseRepository()
        {
            _dbConnection = new MySqlConnection(_connectionString);
        }

        /// <summary>
        /// Lấy thông tin cửa hàng
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MISAEntity> GetAll<MISAEntity>()
        {
            //Ngoặc tròn truyền biến, ngoặc nhọn truyền type
            var className = typeof(MISAEntity).Name;
            var customers = _dbConnection.Query<MISAEntity>($"Proc_Get{className}s", commandType: CommandType.StoredProcedure);
            return customers;
        }

        /// <summary>
        /// Lấy thông Object theo id
        /// </summary>
        /// <returns></returns>
        public MISAEntity GetObjectById<MISAEntity>(Guid storeId)
        {
            // Truyền param vào để tìm kiếm
            var dynamicParams = new DynamicParameters();
            dynamicParams.Add("@StoreId", storeId.ToString());
            var className = typeof(MISAEntity).Name;

            var customer = _dbConnection.Query<MISAEntity>($"Proc_Get{className}s",
                param: dynamicParams,
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            return customer;
        }


        /// <summary>
        /// Thêm cửa hàng
        /// </summary>
        /// <param name="entity"></param>
        public int Insert<MISAEntity>(MISAEntity entity)
        {
            var className = typeof(MISAEntity).Name;
            var res = _dbConnection.Execute($"Proc_Insert{className}",
                entity,
                    commandType: CommandType.StoredProcedure);

            return res;
        }

        /// <summary>
        /// Cập nhật thông tin cửa hàng
        /// </summary>
        /// <param name="entity"></param>
        public int Update<MISAEntity>(MISAEntity entity)
        {
            var className = typeof(MISAEntity).Name;
            var res = _dbConnection.Execute($"Proc_Update{className}",
                entity,
                    commandType: CommandType.StoredProcedure);

            return res;
        }

        /// <summary>
        /// Xóa cửa hàng
        /// </summary>
        /// <param name="entity"></param>
        public int Delete<MISAEntity>(Guid entity)
        {
            var className = typeof(MISAEntity).Name;
            var dynamicParams = new DynamicParameters();
            dynamicParams.Add("@StoreId", entity.ToString());
            var res = _dbConnection.Execute($"Proc_Delete{className}ById",
                param: dynamicParams,
                    commandType: CommandType.StoredProcedure);
            return res;
        }
    }
}

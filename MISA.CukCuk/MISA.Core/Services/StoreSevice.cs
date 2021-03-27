using Dapper;
using MISA.Core.Entities;
using MISA.Core.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public class StoreService : BaseService, IStoreService
    {
        IStoreRepository _storeRepository;
        public StoreService(IBaseRepository baseRepository, IStoreRepository storeRepository):base(baseRepository)
        {
            _storeRepository = storeRepository;
        }

        //public IEnumerable<Store> GetStoreByCode(string storeCode)
        //{
        //    var procName = "Proc_GetStoreByCode";
        //    var stores = _dbConnection.Query<Store>(procName, new { StoreCode = storeCode }, commandType: CommandType.StoredProcedure);
        //    return stores;
        //}

        protected override void ValidateStore<Store>(Store entity)
        {
            // Check trùng mã
            var storeCode = entity.GetType().GetProperty("StoreCode").GetValue(entity).ToString();  // Ép kiểu thành store
            var store = _storeRepository.GetStoreByStoreCode(storeCode);
            if(store != null)
            {
                serviceResult.IsValid = false;
                serviceResult.Msg = "Mã khách hàng không được phép trùng";
                serviceResult.MISACode = "400";
            }

        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MISA.CukCuk.Api.Api
{
    public class StoresController : BaseController<Store>
    {
        protected IStoreService _storeService;

        // Tiêm vào
        //Để dùng được hàm khởi tạo
        public StoresController(IStoreService storeService) : base(storeService)
        {
            this._storeService = storeService;
        }
    }
}

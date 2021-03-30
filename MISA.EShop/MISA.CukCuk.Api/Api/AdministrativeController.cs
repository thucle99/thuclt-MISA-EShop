using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interface;
using MISA.CukCuk.Api.Api;

namespace MISA.EShop.Api.Api
{

    public class AdministrativeUnitController : BaseController<AdministrativeUnit>
    {
        protected IAdministrativeUnitService _administrativeUnitService;

        public AdministrativeUnitController(IAdministrativeUnitService administrativeUnitService) : base(administrativeUnitService)
        {
            this._administrativeUnitService = administrativeUnitService;
        }

    }
}

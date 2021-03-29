using MISA.CukCuk.Api.Api;
using MISA.Core.Entities;
using MISA.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.EShop.Api.Api
{
    public class AdministrativeUnitController:BaseController<AdministrativeUnit>
    {
        protected IAdministrativeUnitService _administrativeUnitService;

        public AdministrativeUnitController(IAdministrativeUnitService administrativeUnitService) : base(administrativeUnitService)
        {
            this._administrativeUnitService = administrativeUnitService;
        }
    }
}

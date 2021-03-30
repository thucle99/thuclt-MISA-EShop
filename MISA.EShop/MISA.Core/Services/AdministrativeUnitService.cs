using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.Core.Entities;
using MISA.Core.Interface;

namespace MISA.Core.Services
{
    public class AdministrativeUnitService :BaseService, IAdministrativeUnitService
    {
        IAdministrativeUnitRepository _administrativeUnitRepository;
        public AdministrativeUnitService(IBaseRepository baseRepository, IAdministrativeUnitRepository administrativeUnitRepository) : base(baseRepository)
        {
            _administrativeUnitRepository = administrativeUnitRepository;
        }

        public IEnumerable<AdministrativeUnit> GetCityById(Guid IdAdministrativeUnit)
        {
            throw new NotImplementedException();
        }
        //IEnumerable<Store> GetCustomerByGender(int gender);
        //IEnumerable<Store> GetCustomerByCode(string customerCode);
    }
}

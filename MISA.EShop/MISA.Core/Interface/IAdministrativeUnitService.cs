using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interface
{
    public interface IAdministrativeUnitService : IBaseService
    {
        IEnumerable<AdministrativeUnit> GetCityById(Guid IdAdministrativeUnit);
    }
}

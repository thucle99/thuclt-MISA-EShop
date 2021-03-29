using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interface
{
    public interface IAdministrativeUnitRepository
    {
        /// <summary>
        /// Lấy thông tin cửa hàng theo mã cửa hàng
        /// </summary>
        /// <param name="storeCode">Mã cửa hàng</param>
        /// <returns>Đối tượng cửa hàng đầu tiên nếu tồn tạo, trả vể null  nếu  không tồn tại khách hàng có mã tương ứng</returns>
        /// CretedBy:LTThuc(29/03/2121) 
        AdministrativeUnit GetCityById(string storeCode);
    }
}

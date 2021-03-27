using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interface
{
    public interface IStoreRepository
    {
        /// <summary>
        /// Lấy thông tin cửa hàng theo mã cửa hàng
        /// </summary>
        /// <param name="storeCode">Mã cửa hàng</param>
        /// <returns>Đối tượng khách hàng đầu tiên nếu tồn tạo, trả vể null  nếu  không tồn tại khách hàng có mã tương ứng</returns>
        /// CretedBy:LTThuc(27/03/2121) 
        Store GetStoreByStoreCode(string storeCode);
    }
}

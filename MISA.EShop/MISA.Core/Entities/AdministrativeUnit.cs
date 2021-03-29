using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Thông tin địa chỉ
    /// CreatedBy: LTTHUC (29/03/2021)
    /// </summary>
    public class AdministrativeUnit
    {
        #region Constructor
        public AdministrativeUnit()
        {

        }
        public AdministrativeUnit(string administrativeUnitCode)
        {
            AdministrativeUnitId = Guid.NewGuid();
            AdministrativeUnitCode = administrativeUnitCode;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Id đơn vị hành chính
        /// </summary>
        public Guid AdministrativeUnitId { get; set; }

        /// <summary>
        /// Mã đơn vị hành chính
        /// </summary>
        public string AdministrativeUnitCode { get; set; }

        /// <summary>
        /// Kiểu đơn vị hành chính: 0-Kiểu quốc gia, 1- Kiểu thành phố, 2- Kiểu huyện/ quận, 3- Kiểu xã/ phường
        /// </summary>
        public string AdministrativeUnitType { get; set; }

        /// <summary>
        /// Tên đơn vị hành chính
        /// </summary>
        public string AdministrativeUnitName { get; set; }


        /// <summary>
        /// Mô tả
        /// </summary>
        public string Decription { get; set; }



        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người tạo
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa
        /// </summary>
        public DateTime? ModifiledDate { get; set; }

        /// <summary>
        /// Ngưởi sửa
        /// </summary>
        public string ModifiledBy { get; set; }
        #endregion
    }
}

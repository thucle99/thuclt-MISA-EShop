using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Thông tin cừa hàng
    /// CreatedBy: LTTHUC (27/03/2021)
    /// </summary>
    public class Store
    {
        #region Declare
        public static List<Store> ListStore = new List<Store>()
        {
        };
        #endregion

        #region Constructor
        public Store()
        {

        }
        /// <summary>
        /// Khởi tạo cửa hàng
        /// </summary>
        /// <param name="storeCode">Cửa hàng</param>
        /// CreatedBy: NVMANH (03/03/2021)
        public Store(string storeCode)
        {
            StoreId = Guid.NewGuid();
            StoreCode = storeCode;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Id cừa hàng
        /// </summary>
        public Guid StoreId { get; set; }

        /// <summary>
        /// Mã cừa hàng
        /// </summary>
        public string StoreCode { get; set; }

        public string StoreName { get; set; }

        /// <summary>
        /// Địa chỉ cửa hàng
        /// </summary>
        public string StoreAddress { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string StorePhoneNumber { get; set; }

        /// <summary>
        /// Trạng thái cửa hàng
        /// </summary>
        public string StatusStore { get; set; }

        public string TaxNumber { get; set; }

        /// <summary>
        /// Id  đơn vị hàng chính cửa hàng
        /// </summary>
        public Guid? AdministrativeUnitId { get; set; }


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

        #region Other

        #endregion
    }
}

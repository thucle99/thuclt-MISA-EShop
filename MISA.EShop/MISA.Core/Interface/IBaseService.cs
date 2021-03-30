using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interface
{
    public interface IBaseService
    {
        //validate dữ liệu

        /// <summary>
        /// Lấy toàn bộ item
        /// </summary>
        /// <typeparam name="MISAEntity">Type</typeparam>
        /// <returns></returns>
        IEnumerable<MISAEntity> GetAll<MISAEntity>();

        /// <summary>
        /// Lấy thông theo khóa chính
        /// </summary>
        /// <typeparam name="MISAEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        MISAEntity GetObjectById<MISAEntity>(Guid entity);

        /// <summary>
        /// Thêm thông tin vào bảng
        /// </summary>
        /// <typeparam name="MISAEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        ServiceResult Insert<MISAEntity>(MISAEntity entity);

        /// <summary>
        /// Sửa thông tin 
        /// </summary>
        /// <typeparam name="MISAEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        ServiceResult Update<MISAEntity>(MISAEntity entity);

        /// <summary>
        /// Xóa thông tin
        /// </summary>
        /// <typeparam name="MISAEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        ServiceResult Delete<MISAEntity>(Guid entity);
    }
}

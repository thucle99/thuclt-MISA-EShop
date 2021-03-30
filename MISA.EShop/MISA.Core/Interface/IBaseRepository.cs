using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interface
{
    public interface IBaseRepository
    {
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
        int Insert<MISAEntity>(MISAEntity entity);

        /// <summary>
        /// Sửa thông tin 
        /// </summary>
        /// <typeparam name="MISAEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update<MISAEntity>(MISAEntity entity);

        /// <summary>
        /// Xóa thông tin
        /// </summary>
        /// <typeparam name="MISAEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Delete<MISAEntity>(Guid entity);
    }
}

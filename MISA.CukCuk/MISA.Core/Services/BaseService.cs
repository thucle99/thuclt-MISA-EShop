using Dapper;
using MISA.Core.Entities;
using MISA.Core.Enum;
using MISA.Core.Interface;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MISA.Core.Services
{
    /// <summary>
    /// Class base xử lý các vấn đề chung về nghiệp vụ
    /// </summary>
    public class BaseService : IBaseService
    {
        IBaseRepository _baseRepository;
        protected ServiceResult serviceResult;
        public BaseService(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
            serviceResult = new ServiceResult();
        }

        /// <summary>
        /// Lấy thông tin cửa hàng
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MISAEntity> GetAll<MISAEntity>()
        {
            return _baseRepository.GetAll<MISAEntity>();
        }

        /// <summary>
        /// Lấy thông Object theo id
        /// </summary>
        /// <returns></returns>
        public MISAEntity GetObjectById<MISAEntity>(Guid entityId)
        {
            return _baseRepository.GetObjectById<MISAEntity>(entityId);
        }


        /// <summary>
        /// Thêm cửa hàng
        /// </summary>
        /// <param name="entity"></param>
        public ServiceResult Insert<MISAEntity>(MISAEntity entity)
        {
            // Xử lý các nghiệp vụ cần thiết
            ValidateObject(entity);
            if (serviceResult.IsValid == false)
            {
                serviceResult.MISACode = MISAConst.IsNoteValid;
            }
            else
            {
                var rowAffects = _baseRepository.Insert<MISAEntity>(entity);
                if (rowAffects <= 0)
                {
                    serviceResult.MISACode = MISAConst.NoteRecodAddToDb;
                    serviceResult.Data = rowAffects;
                    serviceResult.Msg = Properties.Resources.ErrorMsg_NoteRecodAddToDb;
                }
                else
                {
                    serviceResult.MISACode = MISAConst.Success;
                    serviceResult.Data = rowAffects;
                    serviceResult.Msg = Properties.Resources.InsertSuccess;
                }
            }
            return serviceResult;
        }

        /// <summary>
        /// Cập nhật thông tin cửa hàng
        /// </summary>
        /// <param name="entity"></param>
        public ServiceResult Update<MISAEntity>(MISAEntity entity)
        {
            ValidateObject(entity);
            if (serviceResult.IsValid == false)
            {
                serviceResult.MISACode = MISAConst.IsNoteValid; 
            }
            else
            {
                var rowAffects = _baseRepository.Update<MISAEntity>(entity);
                if (rowAffects <= 0)
                {
                    serviceResult.MISACode = MISAConst.NoteRecodAddToDb;
                    serviceResult.Data = rowAffects;
                    serviceResult.Msg = Properties.Resources.ErrorMsg_NoteRecodAddToDb;
                }
                else
                {
                    serviceResult.MISACode = MISAConst.Success;
                    serviceResult.Data = rowAffects;
                    serviceResult.Msg = Properties.Resources.UpdateSuccess;
                }
            }
            return serviceResult;
        }

        /// <summary>
        /// Xóa cửa hàng
        /// </summary>
        /// <param name="entityId"></param>
        public ServiceResult Delete<MISAEntity>(Guid entityId)
        {
            var rowAffects = _baseRepository.Delete<MISAEntity>(entityId);
            if (rowAffects <= 0)
            {
                serviceResult.MISACode = MISAConst.NoteRecodAddToDb;
                serviceResult.Data = rowAffects;
                serviceResult.Msg = Properties.Resources.ErrorUerMsg;
            }
            else
            {
                serviceResult.MISACode = MISAConst.Success;
                serviceResult.Data = rowAffects;
                serviceResult.Msg = Properties.Resources.DeleteSuccess;
            }
            return serviceResult;
        }

        private void ValidateObject<MISAEntity>(MISAEntity entity)
        {
            //1. Kiểm tra thông tin bắt buộc nhập:
            var className = typeof(MISAEntity).Name;
            // Lấy ra property Name theo tên property
            var property = entity.GetType().GetProperty($"{className}Code");
            if (property != null && property.GetValue(entity).ToString() == "")
            {
                serviceResult.IsValid = false;
                serviceResult.Msg = Properties.Resources.ErrorMSG_EmptyCustomerCode;
            }

        }

        protected virtual void ValidateStore<MISAEntity>(MISAEntity entity)
        {

        }
    }
}

﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Enum;
using MISA.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MISA.CukCuk.Api.Api
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<MISAEntity> : ControllerBase
    {
        protected IBaseService _baseService;
        public BaseController(IBaseService baseService)
        {
            this._baseService = baseService;
        }
        /// <summary>
        /// Lấy danh sách item 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = _baseService.GetAll<MISAEntity>().ToList();
            if (entities.Count > 0)
            {
                return StatusCode(200, entities);
            }
            else
            {
                return StatusCode(204, entities);
            }
        }

        /// <summary>
        /// Lấythông tin item theo id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{entityId}")]
        public IActionResult GetById(Guid entityId)
        {
            var store = _baseService.GetObjectById<MISAEntity>(entityId);
            if (store != null)
            {
                return StatusCode(200, store);
            }
            else
            {
                return StatusCode(204, store);
            }
        }

        /// <summary>
        /// Thêm Item
        /// </summary>
        /// <param name="entity"> Thông tin item muốn thêm</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(MISAEntity entity)
        {
            try
            {
                var res = _baseService.Insert<MISAEntity>(entity);
                if (res.MISACode == MISAConst.IsNoteValid)
                {
                    return StatusCode(400, res);
                }
                else if (res.MISACode == MISAConst.Success)
                {
                    return StatusCode(200, res);
                }
                else
                {
                    return StatusCode(500, new
                    {
                        devMsg = res.Msg,
                        userMsg = Core.Properties.Resources.ErrorUerMsg,
                        errorCode = res.MISACode,
                        moreInfo = "",
                        traceId = ""
                    });
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, new
                {
                    devMsg = ex.Message,
                    userMsg = Core.Properties.Resources.ErrorUerMsg,
                    errorCode = MISAConst.Exception,
                    moreInfo = "",
                    traceId = ""
                });
            }

        }

        /// <summary>
        /// Sửa thông tin item
        /// </summary>
        /// <param name="entity"> Thông tin item muốn sửa</param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(MISAEntity entity)
        {
            try
            {
                var res = _baseService.Update<MISAEntity>(entity);
                if (res.MISACode == MISAConst.IsNoteValid)
                {
                    return StatusCode(400, res);
                }
                else if (res.MISACode == MISAConst.Success)
                {
                    return StatusCode(200, res);
                }
                else
                {
                    return StatusCode(500, new
                    {
                        devMsg = res.Msg,
                        userMsg = Core.Properties.Resources.ErrorUerMsg,
                        errorCode = res.MISACode,
                        moreInfo = "",
                        traceId = ""
                    });
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, new
                {
                    devMsg = ex.Message,
                    userMsg = Core.Properties.Resources.ErrorUerMsg,
                    errorCode =  MISAConst.Exception,
                    moreInfo = "",
                    traceId = ""
                });
            }
        }

        /// <summary>
        /// Xóa item
        /// </summary>
        /// <param name="entityId">Id thông tin item muốn xóa</param>
        /// <returns></returns>
        [HttpDelete("{entityId}")]
        public IActionResult Delete(Guid entityId)
        {
            try
            {
                var res = _baseService.Delete<MISAEntity>(entityId);
                if (res.MISACode == MISAConst.IsNoteValid)
                {
                    return StatusCode(400, res);
                }
                else if (res.MISACode == MISAConst.Success)
                {
                    return StatusCode(200, res);
                }
                else
                {
                    return StatusCode(500, new
                    {
                        devMsg = res.Msg,
                        userMsg = Core.Properties.Resources.ErrorUerMsg,
                        errorCode = res.MISACode,
                        moreInfo = "",
                        traceId = ""
                    });
                }             
            }
            catch (Exception ex)
            {

                return StatusCode(500, new
                {
                    devMsg = ex.Message,
                    userMsg = Core.Properties.Resources.ErrorUerMsg,
                    errorCode = MISAConst.Exception,
                    moreInfo = "",
                    traceId = ""
                });
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Api
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerGroupsController : ControllerBase
    {
        /// <summary>
        /// Lấy danh sách nhóm khách hàng
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCustomerGroup()
        {
            var customerGroupService = new CustomerGroupService();
            var customerGroups = customerGroupService.GetCustomerGroups().ToList();
            if (customerGroups.Count > 0)
            {
                return StatusCode(200, customerGroups);
            }
            else
            {
                return StatusCode(204, customerGroups);
            }
        }

        /// <summary>
        /// Lấy khách hàng theo id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{customerGroupId}")]
        public IActionResult GetcustomerGroupById(Guid customerGroupId)
        {
            var customerGroupService = new CustomerGroupService();
            var customerGroup = customerGroupService.GetCustomerGroupById(customerGroupId);
            if (customerGroup != null)
            {
                return StatusCode(200, customerGroup);
            }
            else
            {
                return StatusCode(204, customerGroup);
            }
        }



        [HttpPost]
        public IActionResult post(CustomerGroup customergroup)
        {
            try
            {            
                var customerGroupService = new CustomerGroupService();
                if (customergroup.CustomerGroupName == "")
                {
                    return StatusCode(400, new
                    {
                        devmsg = "CustomerGroupName required!",
                        usermsg = "thông tin nhóm khách hàng không được để trống!",
                        errorcode = "001",
                        moreinfo = "",
                        traceid = ""
                    });
                }
                else
                {
                    customerGroupService.InsertCustomerGroup(customergroup);
                    return StatusCode(201, "thêm thành công!");
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, new
                {
                    devmsg = ex.Message,
                    usermsg = "có lỗi xảy ra, vui lòng liên hệ misa",
                    errorcode = "002",
                    moreinfo = "",
                    traceid = ""
                });
            }

        }
    }

}

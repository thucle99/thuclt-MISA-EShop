using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    public class CustomerGroup
    {
        public static List<CustomerGroup> ListCustomerGroup = new List<CustomerGroup>()
        {
        };
        public Guid CustomerGroupId { get; set; }

        public string CustomerGroupName { get; set; }

        public Guid? ParentId { get; set; }

        public string Description { get; set; }

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

        ///// <summary>
        ///// Ngày sinh
        ///// </summary>
        //public string CustomerGroupCode { get; set; }
        public static List<CustomerGroup> GetCustomerGroups()
        {
            var customerGroups = new List<CustomerGroup>();
            for (int i = 0; i < 10; i++)
            {
                var customerGroup = new CustomerGroup();
                customerGroups.Add(customerGroup);
            }
            ListCustomerGroup = customerGroups;
            return customerGroups;
        }
    }
}

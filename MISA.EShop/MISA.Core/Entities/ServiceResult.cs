using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    public class ServiceResult
    {
        public bool IsValid = true;
        public string Msg { get; set; }

        public object Data { get; set; }

        public string MISACode { get; set; }
    }
}

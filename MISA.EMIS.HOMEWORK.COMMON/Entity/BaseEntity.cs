using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Entity
{
    public class BaseEntity
    {
        public DateTime? CreateDate { get; set; }
        public string? Createby { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Modifiedby { get; set;}
    }
}

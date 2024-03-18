using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Entity
{
    public class Grade : BaseEntity
    {
        public Guid GradeId { get; set; }
        public string GradeName { get; set; }
    }
}

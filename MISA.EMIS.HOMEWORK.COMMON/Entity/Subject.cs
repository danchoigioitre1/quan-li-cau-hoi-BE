using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Entity
{
    public class Subject : BaseEntity
    {
        public Guid SubjectId { get; set; }
        public string? SubjectName { get; set; }

    }
}

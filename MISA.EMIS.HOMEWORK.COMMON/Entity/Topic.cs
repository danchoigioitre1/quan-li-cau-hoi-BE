using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Entity
{
    public class Topic : BaseEntity
    {
        public Guid TopicId { get; set; }
        public string? TopicName { get; set; }
    }
}

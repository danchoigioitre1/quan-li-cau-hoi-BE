using MISA.EMIS.HOMEWORK.COMMON.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Entity
{
    public class Exercise : BaseEntity
    {
        public Guid? ExerciseId { get; set; }
        public string ExerciseName { get; set;}
        public string? ExerciseImage { get; set;}
        public Guid ClassId { get; set; }
        public Guid SubjectId { get; set; } 
        public ExerciseStatusEnums ExerciseStatus { get; set; }
        public string ExerciseTag { get; set; }
        public Guid TopicId { get; set;}
    }
}

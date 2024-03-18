using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Model
{
    public class ExerciseModel 
    {
        
        public Guid ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseTag { get; set; }
        public string TopicName { get; set; }
        public string GradeName { get; set; }
        public string SubjectName { get; set; }
        public ExerciseStatusEnums ExerciseStatus { get; set; }
    }
}

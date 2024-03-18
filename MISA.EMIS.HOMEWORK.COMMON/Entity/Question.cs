using MISA.EMIS.HOMEWORK.COMMON.Enums;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Entity
{
    public class Question 
    {
        public Guid QuestionId { get; set; }
        public string? QuestionContent { get; set; }
        public string? QuestionNote { get; set; }

        public Guid ExerciseId { get; set; }
        public TypeQuestionEnums TypeQuestion { get; set; }
    }
}

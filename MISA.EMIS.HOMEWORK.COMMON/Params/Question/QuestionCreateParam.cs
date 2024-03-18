using MISA.EMIS.HOMEWORK.COMMON.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Params.Question
{
    public class QuestionCreateParam
    {
        public string? QuestionContent { get; set; }
        public string? QuestionNote { get; set; }

        public Guid ExerciseId { get; set; }
        public TypeQuestionEnums TypeQuestion { get; set; }
    }
}

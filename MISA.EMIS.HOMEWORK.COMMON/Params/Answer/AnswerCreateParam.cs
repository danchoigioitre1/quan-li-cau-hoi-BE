using MISA.EMIS.HOMEWORK.COMMON.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Params.Answer
{
    public class AnswerCreateParam
    {
        public string? AnswerContent { get; set; }
        public string? AnswerImage { get; set; }
        public AnswerStatusEnums AnswerStatus { get; set; }
        public Guid QuestionId { get; set; }
    }
}

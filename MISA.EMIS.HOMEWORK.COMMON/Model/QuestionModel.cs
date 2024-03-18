using MISA.EMIS.HOMEWORK.COMMON.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Model
{
    public class QuestionModel
    {
        public Guid QuestionId { get; set; }
        public string QuestionContent { get; set; }
        public string QuestionNote { get; set; }
    
        public int TypeQuestion { get; set; }
        
        public Guid AnswerId { get; set; }
        public string AnswerContent { get; set; }
        public AnswerStatusEnums AnswerStatus { get; set; }
    }
}

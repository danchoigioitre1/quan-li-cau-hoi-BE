using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.AnswerBLApp
{
    public interface IAnswerAppService : IBaseBLApp<Answer, AnswerCreateParam, AnswerUpdateParam>
    {
        Task CreateMultipleAsync(List<AnswerCreateParam> answerCreateParams);
    }
}

using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params.Question;
using MISA.EMIS.HOMEWORK.DL.Repository.QuesitonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.QuestionBLApp
{
    public interface IQuestionAppService : IBaseBLApp<Question, QuestionCreateParam, QuestionUpdateParam>
    {
        public Task<List<QuestionModel>?> GetQuestionAync(Guid exerciseId);
    }
}

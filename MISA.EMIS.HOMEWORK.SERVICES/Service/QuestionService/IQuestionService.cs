using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.COMMON.Params.Question;
using MISA.EMIS.HOMEWORK.DL.Repository.QuesitonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Service.QuestionService
{
    public interface IQuestionService : IBaseService<Question, QuestionCreateParam, QuestionUpdateParam>
    {
        public Task<List<QuestionModel>?> GetQuestionAync(Guid exerciseId);
    }
}

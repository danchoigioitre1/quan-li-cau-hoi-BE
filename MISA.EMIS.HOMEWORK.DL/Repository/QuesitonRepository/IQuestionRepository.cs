using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Repository.QuesitonRepository
{
    public interface IQuestionRepository : IBaseRepository<Question>
    {
        public Task<List<QuestionModel>?> GetQuestionAync(Guid exerciseId);
    }
}

using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Emis.Homework
{
    public interface IEmisHomeworkRepository : IBaseRepository<Exercise>
    {
        public Task<List<Exercise>> GetExercise();
         
        public Task<List<ExerciseModel>?> GetExerciseList(ObjectFilterExercise objectFilterExercise , int pageSize, int pageNumer);

        public Task<List<QuestionModel>?> GetQuestionList(Guid exerciseId);

   
    }
}

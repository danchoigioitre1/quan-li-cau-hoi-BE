using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.COMMON.Params.Answer;
using MISA.EMIS.HOMEWORK.COMMON.Params.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Service.ExerciseService
{
    public interface IExerciseService : IBaseService<Exercise, ExerciseCreateParam, ExerciseUpdateParam>
    {
        Task<List<ExerciseModel>?> GetExerciseListAsync(ObjectFilterExercise objectFilterExercise, int pageSize, int pageNumer);
        public Task ChangeStatusExercise(Guid id);
    }
}

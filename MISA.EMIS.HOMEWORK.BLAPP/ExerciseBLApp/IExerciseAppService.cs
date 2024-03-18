using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params.Answer;
using MISA.EMIS.HOMEWORK.COMMON.Params.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.ExerciseBLApp
{
    public interface IExerciseAppService : IBaseBLApp<Exercise, ExerciseCreateParam, ExerciseUpdateParam>
    {
        Task<List<ExerciseModel>?> GetExerciseListAsync(ObjectFilterExercise objectFilterExercise, int pageSize, int pageNumer);

        Task ChangeStatusExercise(Guid id);
    }
}

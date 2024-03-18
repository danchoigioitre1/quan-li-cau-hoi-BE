using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Repository.ExerciseRepository
{
    public interface IExerciseRepository : IBaseRepository<Exercise>
    {
        Task<List<ExerciseModel>?> GetExerciseList(ObjectFilterExercise objectFilterExercise, int pageSize, int pageNumer);

        Task ChangeStatusExercise(Guid id);
    }
}

using Microsoft.AspNetCore.Mvc;
using MISA.EMIS.HOMEWORK.BL.Service.AnswerService;
using MISA.EMIS.HOMEWORK.BL.Service.ExerciseService;
using MISA.EMIS.HOMEWORK.BLAPP.AnswerBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.ExerciseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.COMMON.Params.Exercise;
using MISA.EMIS.HOMEWORK.Controllers.Base;

namespace MISA.EMIS.HOMEWORK.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class ExerciseController : BaseController<Exercise, ExerciseCreateParam, ExerciseUpdateParam>

    {
        public readonly IExerciseAppService _exerciseAppService;

        public ExerciseController(IExerciseAppService exerciseAppService) : base(exerciseAppService)
        {
            _exerciseAppService = exerciseAppService;
        }

        [HttpPost("getExerciseList")]
        public async Task<List<ExerciseModel>> GetExerciseList(ObjectFilterExercise objectFilterExercise, int pageSize, int pageNumer)
        {
            var exercises = await _exerciseAppService.GetExerciseListAsync(objectFilterExercise, pageSize, pageNumer);
            return exercises;
        }

        [HttpPost("ChangeStatusExercise")]

        public async Task ChangeStatusExercise(Guid id)
        {
            await _exerciseAppService.ChangeStatusExercise(id);  
        }
    }
}

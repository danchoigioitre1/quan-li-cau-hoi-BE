using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.BL.Service;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.Controllers.Base;
using MySqlConnector;

namespace MISA.EMIS.HOMEWORK.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class EmisHomeWorkController 
        //: BaseController<Exercise, Answer>
    {
        //public readonly IEmisHomeworkService _emisHomeworkService;

        //public EmisHomeWorkController(IEmisHomeworkService emisHomeworkService) : base(emisHomeworkService)
        //{
        //    _emisHomeworkService = emisHomeworkService;
        //}
        ///// <summary>
        ///// Api Lấy tất cả bài tập
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet("getAllExercises")]
        //public async Task<List<Exercise>> GetExercisesAsync()
        //{
        //    return await _emisHomeworkService.GetExercise();
        //}

        ///// <summary>
        ///// Api Lấy bài tập theo filter và phân trang
        ///// </summary>
        ///// <returns></returns>
        //[HttpPost("exercises")]
        //public async Task<List<ExerciseModel>> GetExercisesListAsync(ObjectFilterExercise objectFilterExercie, int pageSize, int pageNumer)
        //{
        //    return await _emisHomeworkService.GetExerciseList(objectFilterExercie, pageSize, pageNumer);
        //}

        ///// <summary>
        ///// Api lấy danh sách câu hoi và câu trả lời của 1 exercise thông qua ID
        ///// </summary>
        ///// <param name="exerciseId"></param>
        ///// <returns></returns>
        //[HttpPost("questions")]
        //public async Task<List<QuestionModel>> GetQuestionListAsync(Guid exerciseId)
        //{
        //    return await _emisHomeworkService.GetQuestionList(exerciseId);
        //}


    }
}

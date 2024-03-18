using Microsoft.AspNetCore.Mvc;
using MISA.EMIS.HOMEWORK.BLAPP.ExerciseBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.QuestionBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params.Question;
using MISA.EMIS.HOMEWORK.Controllers.Base;
using MISA.EMIS.HOMEWORK.DL.Repository.QuesitonRepository;

namespace MISA.EMIS.HOMEWORK.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class QuestionController : BaseController<Question, QuestionCreateParam, QuestionUpdateParam>
    {
        public readonly IQuestionAppService _questionAppService;

        public QuestionController(IQuestionAppService questionAppService) : base(questionAppService)
        {
            _questionAppService = questionAppService;
        }

        [HttpPost("getQuestionList")]
        public async Task<List<QuestionModel>?> GetQuestionAync(Guid exerciseId)
        {
            var questions = await _questionAppService.GetQuestionAync(exerciseId);
            return questions;
        }
    }
}

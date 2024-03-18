using Microsoft.AspNetCore.Mvc;
using MISA.EMIS.HOMEWORK.BL.Service;
using MISA.EMIS.HOMEWORK.BL.Service.AnswerService;
using MISA.EMIS.HOMEWORK.BLAPP.AnswerBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.COMMON.Params.Answer;
using MISA.EMIS.HOMEWORK.Controllers.Base;

namespace MISA.EMIS.HOMEWORK.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class AnswerController : BaseController<Answer, AnswerCreateParam, AnswerUpdateParam>
    {
        public readonly IAnswerAppService _answerAppService;

        public AnswerController(IAnswerAppService answerAppService) : base(answerAppService)
        {
            _answerAppService = answerAppService;
        }

        [HttpPost("createMultiple")]
        public virtual async Task createMultiple(List<AnswerCreateParam> entityCreateParams)
        {
            await _answerAppService.CreateMultipleAsync(entityCreateParams);
        }

        [HttpPost("deleteMultipleAnswer")]
        public async Task DeleteMultipleAnswer(List<Guid> ids)
        {
            await _answerAppService.DeleteMultipleAsync(ids);
        }

    }
}

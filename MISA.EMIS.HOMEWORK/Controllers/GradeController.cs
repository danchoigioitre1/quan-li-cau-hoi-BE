using Microsoft.AspNetCore.Mvc;
using MISA.EMIS.HOMEWORK.BLAPP.AnswerBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.GradeBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Grade;
using MISA.EMIS.HOMEWORK.Controllers.Base;

namespace MISA.EMIS.HOMEWORK.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class GradeController : BaseController<Grade,GradeCreateParam,GradeUpdateParam>
    {
        public readonly IGradeAppService _gradeAppService;

        public GradeController(IGradeAppService gradeAppService) : base(gradeAppService)
        {
            _gradeAppService = gradeAppService;
        }

        [HttpGet]
        public async Task<List<Grade>> GetGradesAsync()
        {
            var list = await _gradeAppService.GetAllAsync();
            return list;
        }
    }
}

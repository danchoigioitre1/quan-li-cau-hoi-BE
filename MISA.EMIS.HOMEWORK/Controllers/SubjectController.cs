using Microsoft.AspNetCore.Mvc;
using MISA.EMIS.HOMEWORK.BLAPP.GradeBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.SubjectBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Subject;
using MISA.EMIS.HOMEWORK.Controllers.Base;

namespace MISA.EMIS.HOMEWORK.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class SubjectController : BaseController<Subject,SubjectCreateParam,SubjectUpdateParam>
    {
        public readonly ISubjectAppService _subjectAppService;

        public SubjectController(ISubjectAppService subjectAppService) : base(subjectAppService)
        {
            _subjectAppService = subjectAppService;
        }

        [HttpGet]
        public async Task<List<Subject>> GetGradesAsync()
        {
            var list = await _subjectAppService.GetAllAsync();
            return list;
        }
    }
}

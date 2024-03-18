using Microsoft.AspNetCore.Mvc;
using MISA.EMIS.HOMEWORK.BLAPP.SubjectBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.TopicBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Topic;
using MISA.EMIS.HOMEWORK.Controllers.Base;

namespace MISA.EMIS.HOMEWORK.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class TopicController : BaseController<Topic, TopicCreateParam, TopicUpdateParam>
    {
        public readonly ITopicAppService _topicAppService;

        public TopicController(ITopicAppService topicAppService) : base(topicAppService)
        {
            _topicAppService = topicAppService;
        }

        [HttpGet]
        public async Task<List<Topic>> GetGradesAsync()
        {
            var list = await _topicAppService.GetAllAsync();
            return list;
        }
    }
}

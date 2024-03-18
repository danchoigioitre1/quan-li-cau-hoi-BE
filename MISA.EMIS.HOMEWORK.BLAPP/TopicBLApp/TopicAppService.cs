using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Service.SubjectService;
using MISA.EMIS.HOMEWORK.BL.Service.TopicService;
using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Topic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.TopicBLApp
{
    public class TopicAppService : BLApp<Topic,TopicCreateParam,TopicUpdateParam>, ITopicAppService
    {
        private readonly ITopicService _topicService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TopicAppService(ITopicService topicService, IUnitOfWork unitOfWork) : base(topicService, unitOfWork)
        {
        }
    }
}

using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Topic;
using MISA.EMIS.HOMEWORK.DL.Repository.SubjectRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.TopicRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Service.TopicService
{
    public class TopicService : BaseService<Topic, TopicCreateParam, TopicUpdateParam>, ITopicService
    {
        public readonly ITopicRepository _topicRepository;
        public readonly IMapper _mapper;
        public TopicService(ITopicRepository topicRepository, IMapper mapper) : base(topicRepository, mapper)
        {
            _topicRepository = topicRepository;
            _mapper = mapper;
        }
    }
}

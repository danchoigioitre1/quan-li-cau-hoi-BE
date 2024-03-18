using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.COMMON.Params.Answer;
using MISA.EMIS.HOMEWORK.DL.Base;
using MISA.EMIS.HOMEWORK.DL.Repository.AnswerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Service.AnswerService
{
    public class AnswerService : BaseService<Answer, AnswerCreateParam, AnswerUpdateParam>, IAnswerService
    {
        public readonly IAnswerRepository _answerRepository;
        public readonly IMapper _mapper;
        public AnswerService(IAnswerRepository answerRepository, IMapper mapper) : base(answerRepository, mapper)
        {
            _answerRepository = answerRepository;
            _mapper = mapper;
        }

       
    }
}

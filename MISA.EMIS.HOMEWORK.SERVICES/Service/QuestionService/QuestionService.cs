using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.COMMON.Params.Question;
using MISA.EMIS.HOMEWORK.DL.Base;
using MISA.EMIS.HOMEWORK.DL.Repository.ExerciseRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.QuesitonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Service.QuestionService
{
    public class QuestionService : BaseService<Question, QuestionCreateParam, QuestionUpdateParam>, IQuestionService
    {
        public readonly IQuestionRepository _questionRepository;
        public readonly IMapper _mapper;
        public QuestionService(IQuestionRepository questionRepository, IMapper mapper) : base(questionRepository, mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<List<QuestionModel>?> GetQuestionAync(Guid exerciseId)
        {
            var questions = await _questionRepository.GetQuestionAync(exerciseId);
            return questions;
        }
    }
}

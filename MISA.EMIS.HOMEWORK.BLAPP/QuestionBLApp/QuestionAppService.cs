using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.BL.Service.ExerciseService;
using MISA.EMIS.HOMEWORK.BL.Service.QuestionService;
using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params.Question;
using MISA.EMIS.HOMEWORK.DL.Repository.QuesitonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.QuestionBLApp
{
    public class QuestionAppService : BLApp<Question, QuestionCreateParam, QuestionUpdateParam>, IQuestionAppService
    {
        private readonly IQuestionService _questionService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public QuestionAppService(IQuestionService questionService, IUnitOfWork unitOfWork, IMapper mapper) : base(questionService, unitOfWork)
        {
            _questionService = questionService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<QuestionModel>?> GetQuestionAync(Guid exerciseId)
        {
            var questions = await _questionService.GetQuestionAync(exerciseId);
            return questions;
        }

      
    }
}

using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.BL.Service.AnswerService;
using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.AnswerBLApp
{
    public class AnswerAppService : BLApp<Answer, AnswerCreateParam, AnswerUpdateParam>, IAnswerAppService
    {
        private readonly IAnswerService _answerService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AnswerAppService(IAnswerService answerService, IUnitOfWork unitOfWork, IMapper mapper) : base(answerService, unitOfWork)
        {
            _answerService = answerService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateMultipleAsync(List<AnswerCreateParam> answerCreateParams)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _answerService.CreateMultipleAsync(answerCreateParams);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }
    }
}

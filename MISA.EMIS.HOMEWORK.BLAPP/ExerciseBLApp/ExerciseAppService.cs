using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Service.AnswerService;
using MISA.EMIS.HOMEWORK.BL.Service.ExerciseService;
using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params.Answer;
using MISA.EMIS.HOMEWORK.COMMON.Params.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.ExerciseBLApp
{
    public class ExerciseAppService : BLApp<Exercise, ExerciseCreateParam, ExerciseUpdateParam>, IExerciseAppService
    {
        private readonly IExerciseService _exerciseService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ExerciseAppService(IExerciseService exerciseService, IUnitOfWork unitOfWork, IMapper mapper) : base(exerciseService, unitOfWork)
        {
            _exerciseService = exerciseService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task ChangeStatusExercise(Guid id)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _exerciseService.ChangeStatusExercise(id);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<List<ExerciseModel>?> GetExerciseListAsync(ObjectFilterExercise objectFilterExercise, int pageSize, int pageNumer)
        {
            var exercises = await _exerciseService.GetExerciseListAsync(objectFilterExercise, pageSize, pageNumer);
            return exercises;
        }
    }
}

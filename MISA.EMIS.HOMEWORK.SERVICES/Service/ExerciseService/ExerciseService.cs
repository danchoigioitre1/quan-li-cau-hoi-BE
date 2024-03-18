using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.BL.Service.AnswerService;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.COMMON.Params.Exercise;
using MISA.EMIS.HOMEWORK.DL.Base;
using MISA.EMIS.HOMEWORK.DL.Repository.AnswerRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.ExerciseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Service.ExerciseService
{
    public class ExerciseService : BaseService<Exercise, ExerciseCreateParam, ExerciseUpdateParam>, IExerciseService
    {
        public readonly IExerciseRepository _exerciseRepository;
        public readonly IMapper _mapper;
        public ExerciseService(IExerciseRepository exerciseRepository, IMapper mapper) : base(exerciseRepository, mapper)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
        }

        public async Task ChangeStatusExercise(Guid id)
        {
            var entity = await _exerciseRepository.GetAsync(id);
            if (entity == null)
            {
                throw new Exception("Ban ghi khong ton tai");
            }
            else { await _exerciseRepository.ChangeStatusExercise(id); }
        }

        public async Task<List<ExerciseModel>?> GetExerciseListAsync(ObjectFilterExercise objectFilterExercise, int pageSize, int pageNumer)
        {
            var exercises = await _exerciseRepository.GetExerciseList(objectFilterExercise, pageSize, pageNumer);
            return exercises;
        }
    }
}

using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Grade;
using MISA.EMIS.HOMEWORK.DL.Repository.AnswerRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.GradeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Service.GradeService
{
    public class GradeService : BaseService<Grade, GradeCreateParam, GradeUpdateParam>, IGradeService
    {

        public readonly IGradeRepository _gradeRepository;
        public readonly IMapper _mapper;
        public GradeService(IGradeRepository gradeRepository, IMapper mapper) : base(gradeRepository, mapper)
        {
            _gradeRepository = gradeRepository;
            _mapper = mapper;
        }

    }
}

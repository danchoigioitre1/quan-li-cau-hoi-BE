using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.BL.Service.AnswerService;
using MISA.EMIS.HOMEWORK.BL.Service.GradeService;
using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Grade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.GradeBLApp
{
    public class GradeAppService : BLApp<Grade, GradeCreateParam, GradeUpdateParam>, IGradeAppService
    {
        private readonly IGradeService _gradeService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GradeAppService(IGradeService gradeService, IUnitOfWork unitOfWork) : base(gradeService, unitOfWork)
        {
        }
    }
}

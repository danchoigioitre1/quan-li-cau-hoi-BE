using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Service.GradeService;
using MISA.EMIS.HOMEWORK.BL.Service.SubjectService;
using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.SubjectBLApp
{
    public class SubjectAppService : BLApp<Subject,SubjectCreateParam,SubjectUpdateParam>,ISubjectAppService
    {
        private readonly ISubjectService _subjectService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SubjectAppService(ISubjectService subjectService, IUnitOfWork unitOfWork) : base(subjectService, unitOfWork)
        {
        }
    }
}

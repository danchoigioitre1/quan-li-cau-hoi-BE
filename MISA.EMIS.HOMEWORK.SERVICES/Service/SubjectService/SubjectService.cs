using AutoMapper;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Subject;
using MISA.EMIS.HOMEWORK.DL.Repository.GradeRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.SubjectRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Service.SubjectService
{
    public class SubjectService : BaseService<Subject,SubjectCreateParam,SubjectUpdateParam>, ISubjectService
    {
        public readonly ISubjectRepository _subjectRepository;
        public readonly IMapper _mapper;
        public SubjectService(ISubjectRepository subjectRepository, IMapper mapper) : base(subjectRepository, mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }
    }
}

using AutoMapper;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Question;
using MISA.EMIS.HOMEWORK.COMMON.Params.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Mapper
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<SubjectCreateParam, Subject>();
            CreateMap<SubjectUpdateParam, Subject>();
        }
    }
}

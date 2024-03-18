using AutoMapper;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Answer;
using MISA.EMIS.HOMEWORK.COMMON.Params.Grade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.Mapper
{
    public class GradeProfile : Profile
    {
        public GradeProfile()
        {
            CreateMap<GradeCreateParam, Grade>();
            CreateMap<GradeUpdateParam, Grade>();
        }
    }
}

using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Grade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Service.GradeService
{
    public interface IGradeService : IBaseService<Grade,GradeCreateParam,GradeUpdateParam>
    {

    }
}

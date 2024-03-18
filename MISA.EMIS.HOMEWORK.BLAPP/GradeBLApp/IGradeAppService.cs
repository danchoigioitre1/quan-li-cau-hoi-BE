using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Grade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.GradeBLApp
{
    public interface IGradeAppService : IBaseBLApp<Grade, GradeCreateParam, GradeUpdateParam>
    {
    }
}

using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params.Subject;
using MISA.EMIS.HOMEWORK.COMMON.Params.Topic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.SubjectBLApp
{
    public interface ISubjectAppService : IBaseBLApp<Subject, SubjectCreateParam, SubjectUpdateParam>
    {
    }
}

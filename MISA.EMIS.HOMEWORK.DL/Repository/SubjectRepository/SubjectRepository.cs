using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Repository.SubjectRepository
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public SubjectRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}

using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Repository.GradeRepository
{
    public class GradeRepository : BaseRepository<Grade>, IGradeRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public GradeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }
}

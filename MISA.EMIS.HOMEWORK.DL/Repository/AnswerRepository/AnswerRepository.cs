using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Repository.AnswerRepository
{
    public class AnswerRepository : BaseRepository<Answer>, IAnswerRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public AnswerRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
       

    }
}

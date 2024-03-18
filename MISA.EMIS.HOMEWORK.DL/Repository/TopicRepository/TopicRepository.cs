using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Repository.TopicRepository
{
    public class TopicRepository : BaseRepository<Topic>, ITopicRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public TopicRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}

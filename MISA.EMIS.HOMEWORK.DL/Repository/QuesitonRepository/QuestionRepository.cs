using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Repository.QuesitonRepository
{
    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuestionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<QuestionModel>?> GetQuestionAync(Guid exerciseId)
        {
            try
            {
                var query = "proc_GetQuestions";
                var dynamicParam = new DynamicParameters();
                dynamicParam.Add("$exerciseId", exerciseId);
                var questions = await _unitOfWork.Connection.QueryAsync<QuestionModel>(query, dynamicParam, transaction: _unitOfWork.Transaction, commandType: System.Data.CommandType.StoredProcedure);
               
                return (List<QuestionModel>?)questions;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

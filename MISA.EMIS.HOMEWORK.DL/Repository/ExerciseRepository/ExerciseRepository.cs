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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace MISA.EMIS.HOMEWORK.DL.Repository.ExerciseRepository
{
    public class ExerciseRepository : BaseRepository<Exercise>, IExerciseRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public ExerciseRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task ChangeStatusExercise(Guid id)
        {
            try
            {
                string sql = $"UPDATE emis_exercise ee SET ee.ExerciseStatus = 2 WHERE ee.ExerciseId =  @id";
                var parameters = new DynamicParameters();
                parameters.Add("@id", id);
                await _unitOfWork.Connection.ExecuteAsync(sql, parameters, transaction: _unitOfWork.Transaction);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ExerciseModel>?> GetExerciseList(ObjectFilterExercise objectFilterExercise, int pageSize, int pageNumer)
        {
            try
            {
                var filterString = "";
                var properties = objectFilterExercise.GetType().GetProperties();

                // Duyệt qua từng thuộc tính và in ra key và value tương ứng
                for (int i = 0; i < properties.Length; i++)
                {
                    if (i != properties.Length - 1)
                    {

                        string propertyName = properties[i].Name;
                        object propertyValue = properties[i].GetValue(objectFilterExercise);
                        if (propertyValue != null)
                        {
                            filterString += $"{propertyName} LIKE '%{propertyValue}%' AND ";
                        }

                    }
                    else
                    {
                        string propertyName = properties[i].Name;
                        object propertyValue = properties[i].GetValue(objectFilterExercise);
                        if (propertyValue != null)
                        {
                            filterString += $"{propertyName} LIKE '%{propertyValue}%'";
                        }
                        else
                        {
                            filterString += "1 = 1";
                        }
                    }
                }
                var query = "proc_GetExercies";
                var dynamicParam = new DynamicParameters();
                dynamicParam.Add("$filterString", filterString);
                dynamicParam.Add("$pageSize", pageSize);
                dynamicParam.Add("$pageNumber", pageNumer);
                var exercises = await _unitOfWork.Connection.QueryAsync<ExerciseModel>(query, dynamicParam, transaction: _unitOfWork.Transaction, commandType: System.Data.CommandType.StoredProcedure);

                return (List<ExerciseModel>)exercises;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

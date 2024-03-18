using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Model;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Emis.Homework
{
    public class EmisHomeworkRepository 
        //: BaseRepository<Exercise>, IEmisHomeworkRepository
    {
        //public EmisHomeworkRepository(IConfiguration configuration) : base(configuration)
        //{
        //}

        //public async Task<List<Exercise>> GetExercise()
        //{
        //    // Khởi tạo kết nối tới DB
        //    var connection = await GetOpenConnectionAsync();

        //    try
        //    {
        //        // Khởi tạo câu lệnh sql
        //        var query = "SELECT * FROM emis_exercise ee;";
        //        // Lấy danh sách các keys trong emulationCreate

        //        // Thực hiện câu lệnh sql
        //        var exercise = await connection.QueryAsync<Exercise>(query);
        //        await connection.CloseAsync();
        //        return (List<Exercise>)exercise;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("loi roi kia");
        //    }


        //}

        //public async Task<List<ExerciseModel>?> GetExerciseList(ObjectFilterExercise objectFilterExercise, int pageSize, int pageNumer)
        //{

        //    var connection = await GetOpenConnectionAsync();

        //    try
        //    {
        //        var filterString = "";
        //        PropertyInfo[] properties = objectFilterExercise.GetType().GetProperties();

        //        // Duyệt qua từng thuộc tính và in ra key và value tương ứng
        //        for (int i = 0; i < properties.Length; i++)
        //        {
        //            if (i != properties.Length - 1)
        //            {

        //                string propertyName = properties[i].Name;
        //                object propertyValue = properties[i].GetValue(objectFilterExercise);
        //                if (propertyValue != null)
        //                {
        //                    filterString += $"{propertyName} LIKE '%{propertyValue}%' AND ";
        //                }

        //            }
        //            else
        //            {
        //                string propertyName = properties[i].Name;
        //                object propertyValue = properties[i].GetValue(objectFilterExercise);
        //                if (propertyValue != null)
        //                {
        //                    filterString += $"{propertyName} LIKE '%{propertyValue}%'";
        //                }
        //                else
        //                {
        //                    filterString += "1 = 1";
        //                }
        //            }
        //        }
        //        var query = "proc_GetExercies";
        //        var dynamicParam = new DynamicParameters();
        //        dynamicParam.Add("$filterString", filterString);
        //        dynamicParam.Add("$pageSize", pageSize);
        //        dynamicParam.Add("$pageNumber", pageNumer);
        //        var exercise = await connection.QueryAsync<ExerciseModel>(query, dynamicParam, commandType: System.Data.CommandType.StoredProcedure);
        //        await connection.CloseAsync();
        //        return (List<ExerciseModel>?)exercise;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("loi roi kia");
        //    }
        //}

        //public async Task<List<QuestionModel>?> GetQuestionList(Guid exerciseId)
        //{
        //    var connection = await GetOpenConnectionAsync();

        //    try
        //    {
                
        //        var query = "proc_GetQuestions";
        //        var dynamicParam = new DynamicParameters();
        //        dynamicParam.Add("$exerciseId", exerciseId);
        //        var exercise = await connection.QueryAsync<QuestionModel>(query, dynamicParam, commandType: System.Data.CommandType.StoredProcedure);
        //        await connection.CloseAsync();
        //        return (List<QuestionModel>?)exercise;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("loi roi kia");
        //    }
        //}
    }
}

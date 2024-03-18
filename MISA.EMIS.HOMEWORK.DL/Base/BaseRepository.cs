using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.COMMON.Entity;
using MISA.EMIS.HOMEWORK.COMMON.Params;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        protected readonly IUnitOfWork _unitOfWork;
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual async Task<Guid> CreateAsync(TEntity entity)
        {

            try
            {
                var table = typeof(TEntity).Name;
                var query = $"proc_Create{table}";
                var parameters = new DynamicParameters();
                var properties = entity.GetType().GetProperties();
                var newGuid = Guid.NewGuid();
                for (int i = 0; i < properties.Length; i++)
                {

                    var property = properties[i];
                    var paramName = "$" + property.Name;
                    if (paramName == "$CreateDate" || paramName == "$CreateBy" || paramName == "$ModifiedDate" || paramName == "$ModifiedBy")
                    {
                        continue;
                    }
                    if (paramName == $"${table}Id")
                    {

                        parameters.Add(paramName, newGuid);

                    }
                    else
                    {
                        var paramValue = property.GetValue(entity);
                        parameters.Add(paramName, paramValue);
                    }


                }


                await _unitOfWork.Connection.ExecuteAsync(query, parameters, transaction: _unitOfWork.Transaction, commandType: System.Data.CommandType.StoredProcedure);

                return newGuid;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public virtual async Task DeleteAsync(Guid id)
        {

            try
            {
                var table = typeof(TEntity).Name;
                var sqlDelete = $"proc_Delete{table}ById";
                var dynamicParam = new DynamicParameters();
                dynamicParam.Add($"${table}Id", id);
                await _unitOfWork.Connection.ExecuteAsync(sqlDelete, dynamicParam, transaction: _unitOfWork.Transaction, commandType: System.Data.CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

        public async virtual Task<TEntity?> GetAsync(Guid id)
        {
            try
            {
                //Chuẩn bị store
                var table = typeof(TEntity).Name;
                string sql = $"SELECT * FROM emis_{table} ee WHERE ee.{table}Id = @id";
                //Chuẩn bị tham số đầu vào
                var parameters = new DynamicParameters();
                parameters.Add("@id", id);
                //Thực hiện câu lệnh sql
                var entity = await _unitOfWork.Connection.QueryFirstOrDefaultAsync<TEntity>(sql, parameters, transaction: _unitOfWork.Transaction);
                return entity;
            }
            catch (Exception ex)
            {
                //Thông báo nếu lỗi
                throw new Exception(ex.Message);
            }
        }

        public virtual async Task UpdateAsync(Guid id, TEntity entity)
        {

            try
            {
                var table = typeof(TEntity).Name;

                var query = $"proc_update{table}";

                var parameters = new DynamicParameters();

                var properties = entity.GetType().GetProperties();

                for (int i = 0; i < properties.Length; i++)
                {
                    var property = properties[i];
                    var paramname = "$" + property.Name;
                    var paramvalue = property.GetValue(entity);
                    parameters.Add(paramname, paramvalue);
                }
                parameters.Add($"${table}id", id);

                await _unitOfWork.Connection.ExecuteAsync(query, parameters, transaction: _unitOfWork.Transaction, commandType: System.Data.CommandType.StoredProcedure);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public virtual async Task<List<TEntity>> InsertMultipleAsync(List<TEntity> listEntities)
        {
            try
            {
                var table = typeof(TEntity).Name;
                var props = typeof(TEntity).GetProperties();
                var parameters = new List<TEntity>();

                foreach (var entity in listEntities)
                {
                    var parameter = Activator.CreateInstance<TEntity>();
                    foreach (var prop in entity.GetType().GetProperties())
                    {
                        if (prop.Name == $"{table}Id")
                        {
                            var newId = Guid.NewGuid();
                            prop.SetValue(entity, newId);
                            prop.SetValue(parameter, newId);
                        }
                        else
                        {
                            var propValue = prop.GetValue(entity);
                            prop.SetValue(parameter, propValue);
                        }
                    }
                    parameters.Add(parameter);
                }

                var sql = $"INSERT INTO emis_{table} ({string.Join(", ", props.Select(p => p.Name))}) " +
                          $"VALUES (@{string.Join(", @", props.Select(p => p.Name))})";

                // Execute the SQL statement once for all entities
                var rowsAffected = await _unitOfWork.Connection.ExecuteAsync(sql, parameters, transaction: _unitOfWork.Transaction);
                if (rowsAffected > 0)
                {
                    return listEntities;
                }
                else
                {
                    //Thông báo nếu lỗi
                    throw new Exception("Không thể thêm");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            try
            {
                var table = typeof(TEntity).Name;
                var sql = $"SELECT * FROM emis_{table}";
                var list = await _unitOfWork.Connection.QueryAsync<TEntity>(sql, transaction: _unitOfWork.Transaction);
                return (List<TEntity>)list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteMultiple(List<Guid> ids)
        {
            try
            {
                var table = typeof(TEntity).Name;
                //Check trùng
                var select = $"DELETE FROM emis_{table}  WHERE {table}Id IN @Ids";
                var parameter = new DynamicParameters();
                parameter.Add("@Ids", ids);
                await _unitOfWork.Connection.ExecuteAsync(select, parameter, transaction: _unitOfWork.Transaction);
            }
            catch (Exception ex)
            {
                //Thông báo nếu lỗi
                throw new Exception(ex.Message);
            }
        }

        //public async Task<TEntity?> GetAsync(Guid id)
        //{
        //    try
        //    {
        //        var table = typeof(TEntity).Name;

        //        // Mở kết nối tới DB
        //        var connection = await GetOpenConnectionAsync();
        //        // Khởi tạo câu lệnh sql
        //        var sql = $"proc_get{table}ById";
        //        // Khởi tạo tham số đầu vào
        //        var dynamicParam = new DynamicParameters();
        //        dynamicParam.Add($"${table}Id", id);
        //        // Thực thi câu lệnh sql và gán giá trị trả về 
        //        var entity = await connection.QueryFirstOrDefaultAsync<TEntity>(sql, dynamicParam, commandType: System.Data.CommandType.StoredProcedure);
        //        // Đóng kết nối tới DB
        //        await connection.CloseAsync();
        //        // Trả về giá trị
        //        return entity;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("co loi");
        //    }

        //}

        //public async Task<DbConnection> GetOpenConnectionAsync()
        //{
        //    // Khởi tạo đối tượng kết nối
        //    var connection = new MySqlConnection(_connetionString);
        //    // Mở kết nối tới DB
        //    await connection.OpenAsync();
        //    // Trả về đối tượng kết nối
        //    return connection;
        //}

        //public async virtual Task UpdateAsync(Guid id, TEntity entity)
        //{
        //    var connection = await GetOpenConnectionAsync();

        //    var transaction = await connection.BeginTransactionAsync();
        //    try
        //    {
        //        var table = typeof(TEntity).Name;

        //        var query = $"proc_Update{table}";

        //        var parameters = new DynamicParameters();

        //        var properties = entity.GetType().GetProperties();

        //        for (int i = 0; i < properties.Length; i++)
        //        {
        //            var property = properties[i];
        //            var paramName = "$" + property.Name;
        //            var paramValue = property.GetValue(entity);
        //            parameters.Add(paramName, paramValue);
        //        }
        //        parameters.Add($"${table}Id", id);

        //        await connection.ExecuteAsync(query, parameters, transaction: transaction, commandType: System.Data.CommandType.StoredProcedure);

        //        await transaction.CommitAsync();
        //    }
        //    catch (Exception ex)
        //    {

        //        await transaction.RollbackAsync();
        //        throw new Exception("Co loi roi");
        //    }
        //    finally
        //    {

        //        await transaction.DisposeAsync();
        //        await connection.CloseAsync();
        //        await connection.DisposeAsync();
        //    }
        //}

        //public async virtual Task<TEntity> CreateAsync(TEntity entity)
        //{

        //    var connection = await GetOpenConnectionAsync();

        //    var transaction = await connection.BeginTransactionAsync();
        //    try
        //    {
        //        var table = typeof(TEntity).Name;
        //        var query = $"proc_Create{table}";
        //        var parameters = new DynamicParameters();
        //        var properties = entity.GetType().GetProperties();

        //        for (int i = 0; i < properties.Length; i++)
        //        {

        //            var property = properties[i];
        //            var paramName = "$" + property.Name;
        //            if (paramName == $"${table}Id")
        //            {
        //                var newGuid = Guid.NewGuid();
        //                parameters.Add(paramName, newGuid);
        //            }
        //            else
        //            {
        //                var paramValue = property.GetValue(entity);
        //                parameters.Add(paramName, paramValue);
        //            }

        //        }

        //        await connection.ExecuteAsync(query, parameters, transaction: transaction, commandType: System.Data.CommandType.StoredProcedure);
        //        await transaction.CommitAsync();
        //        return entity;
        //    }
        //    catch (Exception ex)
        //    {

        //        await transaction.RollbackAsync();
        //        throw new Exception("Co loi roi");
        //    }
        //    finally
        //    {

        //        await transaction.DisposeAsync();
        //        await connection.CloseAsync();
        //    }
        //}
    }
}

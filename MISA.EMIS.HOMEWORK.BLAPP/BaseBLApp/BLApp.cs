using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp
{
    public abstract class BLApp<TEntity, TEntityCreateParam, TEntityUpdateParam> : IBaseBLApp<TEntity, TEntityCreateParam, TEntityUpdateParam>
    {

        private readonly IBaseService<TEntity, TEntityCreateParam, TEntityUpdateParam> _baseService;
        private readonly IUnitOfWork _unitOfWork;
        public BLApp(IBaseService<TEntity, TEntityCreateParam, TEntityUpdateParam> baseService, IUnitOfWork unitOfWork)
        {
            _baseService = baseService;
            _unitOfWork = unitOfWork;
        }


        public virtual async Task<Guid> CreateAsync(TEntityCreateParam entityCreateParam)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var entityId = await _baseService.CreateAsync(entityCreateParam);

                await _unitOfWork.CommitAsync();
                return entityId;
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public virtual async Task UpdateAsync(Guid id, TEntityUpdateParam entityUpdateParam)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _baseService.UpdateAsync(id, entityUpdateParam);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _baseService.DeleteAsync(id);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var list = await _baseService.GetAllAsync();
                await _unitOfWork.CommitAsync();
                return list;
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task DeleteMultipleAsync(List<Guid> ids)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _baseService.DeleteMultipleAsync(ids);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

      
    }
}

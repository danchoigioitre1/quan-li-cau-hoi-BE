using AutoMapper;
using MISA.EMIS.HOMEWORK.DL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Base
{
    public abstract class BaseService<TEntity, TEntityCreateParam, TEntityUpdateParam> : IBaseService<TEntity, TEntityCreateParam, TEntityUpdateParam>
    {
        protected readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;
        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;

        }
        public virtual async Task<Guid> CreateAsync(TEntityCreateParam entityCreateParam)
        {
            var newEntity = _mapper.Map<TEntityCreateParam, TEntity>(entityCreateParam);
            var createdEntityId = await _baseRepository.CreateAsync(newEntity);
            return createdEntityId;
        }

        public async Task CreateMultipleAsync(List<TEntityCreateParam> entityCreateParams)
        {
            var newlistEntities = _mapper.Map<List<TEntityCreateParam>, List<TEntity>>(entityCreateParams);

            await _baseRepository.InsertMultipleAsync(newlistEntities);
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await _baseRepository.GetAsync(id);
            //Nếu không tồn tại thì trả về NotFound
            if (entity == null)
            {
                throw new Exception("Ban ghi khong ton tai");
            }
            else { await _baseRepository.DeleteAsync(id); }

        }

        public async Task DeleteMultipleAsync(List<Guid> ids)
        {
            if (ids == null)
            {
                throw new Exception("Mảng id ko phù hợp");
            }
            else
            {
                await _baseRepository.DeleteMultiple(ids);
            }
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            var list = _baseRepository.GetAllAsync();
            return list;
        }

        public virtual async Task<TEntity?> GetAsync(Guid id)
        {
            // Kiểm tra dữ liệu từ DB trước khi get
            var entity = await _baseRepository.GetAsync(id);
            if (entity == null)
            {
                // Nếu null thì throw 1 exception
                throw new Exception("khong tim thay");
            }
            // Chuyển đổi kiểu cho phù hợp với kết quả trả về

            return entity;
        }

        public virtual async Task UpdateAsync(Guid id, TEntityUpdateParam entityUpdateParam)
        {
            var newEntity = _mapper.Map<TEntityUpdateParam, TEntity>(entityUpdateParam);
            await _baseRepository.UpdateAsync(id, newEntity);
        }


    }
}

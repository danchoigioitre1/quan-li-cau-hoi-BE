using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BL.Base
{
    public interface IBaseService<TEntity, TEntityCreateParam, TEntityUpdateParam>
    {
        Task<TEntity?> GetAsync(Guid id);

        /// <summary>
        /// Service cập nhật 1 bản ghi
        /// </summary>
        /// <param name="id">mã id của bản ghi</param>
        /// <param name="entityUpdateParam">các field mới của bản ghi</param>
        /// CreatedBy : NVAnh - MF1618
        Task UpdateAsync(Guid id, TEntityUpdateParam entityUpdateParam);

        /// <summary>
        /// Xóa 1 bản ghi
        /// </summary>
        /// <param name="id">mã id của bản ghi</param>
        /// CreatedBy : NVAnh - MF1618
        Task DeleteAsync(Guid id);

        /// <summary>
        /// Tạo mới 1 bản ghi
        /// </summary>
        /// <param name="entityCreateParam"></param>
        /// CreatedBy : NVAnh - MF1618
        Task<Guid> CreateAsync(TEntityCreateParam entityCreateParam);

        Task CreateMultipleAsync(List<TEntityCreateParam> entityCreateParams);

        Task<List<TEntity>> GetAllAsync();
    
        Task DeleteMultipleAsync(List<Guid> ids);
    }
}

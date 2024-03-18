using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.DL.Base
{
    public interface IBaseRepository<TEntity>
    {
        /// <summary>
        /// hàm mở kết nối tới DB
        /// </summary>
        /// <returns> Mở kết nối tới DB </returns>
        /// createdBy: NVAnh - MF1618
        //Task<DbConnection> GetOpenConnectionAsync();

        /// <summary>
        /// hàm lấy data theo id
        /// </summary>
        /// <param name="id">id của bản ghi</param>
        /// <returns>1 bản ghi</returns>
        /// createdBy: NVAnh - MF1618
        Task<TEntity?> GetAsync(Guid id);

        /// <summary>
        /// hàm update data
        /// </summary>
        /// <param name="id"> id của bản ghi muốn cập nhật</param>
        /// <param name="entity"> các field mới của entity </param>
        /// createdBy: NVAnh - MF1618
        Task UpdateAsync(Guid id, TEntity entity);

        /// <summary>
        /// hàm xóa bản ghi theo id
        /// </summary>
        /// <param name="id">id của bản ghi muốn xóa</param>
        /// <returns></returns>
        /// createdBy: NVAnh - MF1618
        Task DeleteAsync(Guid id);

        Task<Guid> CreateAsync(TEntity entity);

        Task<List<TEntity>> InsertMultipleAsync(List<TEntity> listEntities);

        Task<List<TEntity>> GetAllAsync();

        Task DeleteMultiple(List<Guid> ids);
    }
}

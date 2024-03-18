using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp
{
    public interface IBaseBLApp<TEntity, TEntityCreateParam, TEntityUpdateParam>
    {
        
        Task UpdateAsync(Guid id, TEntityUpdateParam entityUpdateParam);

        Task<Guid> CreateAsync(TEntityCreateParam entityCreateParam);
       
        Task DeleteAsync(Guid id);

        Task<List<TEntity>> GetAllAsync();

        Task DeleteMultipleAsync(List<Guid> ids);
        //Task CreateMultipleAsync(List<TEntityCreateParam> entityCreateParams);
    }
}

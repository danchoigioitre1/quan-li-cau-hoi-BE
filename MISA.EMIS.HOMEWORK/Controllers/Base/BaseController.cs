using Microsoft.AspNetCore.Mvc;
using MISA.EMIS.HOMEWORK.BL.Base;
using MISA.EMIS.HOMEWORK.BLAPP.BaseBLApp;

namespace MISA.EMIS.HOMEWORK.Controllers.Base
{
    [ApiController]
    public class BaseController<TEntity, TEntityCreateParam, TEntityUpdateParam> : ControllerBase
    {
        protected readonly IBaseBLApp<TEntity, TEntityCreateParam, TEntityUpdateParam> _baseBLApp;
        public BaseController(IBaseBLApp<TEntity, TEntityCreateParam, TEntityUpdateParam> baseBLApp)
        {
            _baseBLApp = baseBLApp;
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await _baseBLApp.DeleteAsync(id);
        }

        [HttpPost("create")]
        public async Task<Guid> CreateAsync([FromBody] TEntityCreateParam entity)
        {
            var createdEntityId = await _baseBLApp.CreateAsync(entity);
            return createdEntityId;
        }

        [HttpPost("update")]
        public virtual async Task UpdateAsync([FromBody] TEntityUpdateParam entityUpdateParam, Guid id)
        {
            await _baseBLApp.UpdateAsync(id, entityUpdateParam);
        }

        //[HttpPost("createMultiple")]
        //public virtual async Task createMultiple(List<TEntityCreateParam> entityCreateParams)
        //{
        //    await _baseBLApp.CreateMultipleAsync(entityCreateParams);
        //}

    }
}

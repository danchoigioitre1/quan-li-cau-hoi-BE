using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.EMIS.HOMEWORK.COMMON.DataConection
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        DbConnection Connection { get; }
        DbTransaction? Transaction { get; }
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
        Task GetOpenConnectionAsync();
    }
}

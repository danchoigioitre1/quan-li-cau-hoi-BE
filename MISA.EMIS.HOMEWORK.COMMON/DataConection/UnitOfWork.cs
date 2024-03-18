using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace MISA.EMIS.HOMEWORK.COMMON.DataConection
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbConnection _connection;
        private DbTransaction? _transaction = null;

        public UnitOfWork(IConfiguration configuration)
        {
            _connection = new MySqlConnection(configuration["ConnectionString"]);
        }

        public DbConnection Connection => _connection;

        public DbTransaction? Transaction => _transaction;

        
        public async Task BeginTransactionAsync()
        {
            await GetOpenConnectionAsync();
            if (_transaction == null)
                _transaction = await _connection.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
            }
            await DisposeAsync();
            await CloseConnectionAsync();
        }

        public async ValueTask DisposeAsync()
        {
            if (_transaction != null)
            {
                await _transaction.DisposeAsync();
            }
            _transaction = null;
        }

        public async Task GetOpenConnectionAsync()
        {
            if (_connection.State == ConnectionState.Closed)
                await _connection.OpenAsync();
        }
        public async Task CloseConnectionAsync()
        {
            if (_connection.State == ConnectionState.Open)
            {
                await _connection.CloseAsync();
                await _connection.DisposeAsync();
            } 
                
               
             
        }
        public async Task RollbackAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
            }
            await DisposeAsync();
            await CloseConnectionAsync();
        }
    }
}

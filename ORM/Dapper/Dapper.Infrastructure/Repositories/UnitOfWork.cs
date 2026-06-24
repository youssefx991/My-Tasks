using Dapper.Core.Entities;
using Dapper.Core.Interfaces;
using Dapper.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Product> Products { get; }

        public UnitOfWork(DapperContext context)
        {
            var connection = context.CreateConnection();

            Products = new ProductRepository(connection);
        }

        public Task BeginTransactionAsync()
        {
            return Task.CompletedTask;
        }

        public Task CommitAsync()
        {
            return Task.CompletedTask;
        }

        public Task RollbackAsync()
        {
            return Task.CompletedTask;
        }
    }
}

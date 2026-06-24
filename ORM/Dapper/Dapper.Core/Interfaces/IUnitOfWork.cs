using Dapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<Product> Products { get; }

        Task BeginTransactionAsync();

        Task CommitAsync();

        Task RollbackAsync();
    }
}

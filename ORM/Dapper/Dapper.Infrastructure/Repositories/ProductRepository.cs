using Dapper.Core.Entities;
using Dapper.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Dapper.Infrastructure.Repositories
{
    public class ProductRepository : IProductsRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            string sql = "SELECT * FROM Products";

            return await _connection.QueryAsync<Product>(sql);
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            string sql =
                "SELECT * FROM Products WHERE Id=@Id";

            return await _connection.QueryFirstOrDefaultAsync<Product>(
                sql,
                new { Id = id });
        }

        public async Task<int> AddAsync(Product product)
        {
            string sql = @"
        INSERT INTO Products(Name,Price)
        VALUES(@Name,@Price);

        SELECT CAST(SCOPE_IDENTITY() as int);
        ";

            return await _connection.ExecuteScalarAsync<int>(
                sql,
                product);
        }

        public async Task<bool> UpdateAsync(Product product)
        {
            string sql = @"
        UPDATE Products
        SET Name=@Name,
            Price=@Price
        WHERE Id=@Id";

            int rows =
                await _connection.ExecuteAsync(sql, product);

            return rows > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            string sql =
                "DELETE FROM Products WHERE Id=@Id";

            int rows =
                await _connection.ExecuteAsync(
                    sql,
                    new { Id = id });

            return rows > 0;
        }
    }
}

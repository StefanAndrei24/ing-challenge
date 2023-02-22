using Bank.Contracts.Queries;
using Bank.Infrastructure.DataAccess;
using Bank.Models.Queries;
using Microsoft.EntityFrameworkCore;

namespace Bank.CQS.Queries
{
    public class CategoryQuery : ICategoryQuery
    {
        public CategoryQuery(BankDb bankDb)
        {
            BankDb = bankDb;
        }

        private BankDb BankDb { get; }

        public async Task<List<CategoryQueryResponse>> GetCategoriesAsync() =>
            await BankDb.Categories.AsNoTracking()
            .Select(category => new CategoryQueryResponse
            {
                Name = category.Name,
            })
            .ToListAsync();
    }
}

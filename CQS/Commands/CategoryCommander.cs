using Bank.Contracts.Commands;
using Bank.Infrastructure.DataAccess;
using Bank.Infrastructure.Entities;

namespace Bank.CQS.Commands
{
    public class CategoryCommander : ICategoryCommander
    {
        public CategoryCommander(BankDb bankDb)
        {
            BankDb = bankDb;
        }

        private BankDb BankDb { get; }

        public async Task<bool> AddCategoryAsync(string categoryName)
        {
            var category = new Category { Name = categoryName };

            BankDb.Categories.Add(category);
            return await BankDb.SaveChangesAsync() > 0;
        }
    }
}

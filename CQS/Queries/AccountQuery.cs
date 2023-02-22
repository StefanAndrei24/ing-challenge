using Bank.Contracts.Queries;
using Bank.Infrastructure.DataAccess;
using Bank.Models.Queries;
using Microsoft.EntityFrameworkCore;

namespace Bank.CQS.Queries
{
    public class AccountQuery : IAccountQuery
    {
        public AccountQuery(BankDb bankDb)
        {
            BankDb = bankDb;
        }

        private BankDb BankDb { get; }

        public async Task<List<AccountQueryResponse>> GetAccountsAsync() =>
            await BankDb.Accounts.AsNoTracking()
            .Select(account => new AccountQueryResponse
            {
                Currency = account.Currency,
                Iban = account.Iban,
                Name = account.Name,
                Product = account.Product,
                ResourceId = account.ResourceId,
            })
            .ToListAsync();

        public async Task<List<AccountQueryResponse>> GetAccountsByClientIdAsync(long clientId) =>
            await BankDb.Accounts
                .Include(entity => entity.Client)
                .AsNoTracking()
                .Where(account => account.ClientId == clientId)
                .Select(account => new AccountQueryResponse
                {
                    Currency = account.Currency,
                    Iban = account.Iban,
                    Name = account.Name,
                    Product = account.Product,
                    ResourceId = account.ResourceId,
                })
                .ToListAsync();
    }
}

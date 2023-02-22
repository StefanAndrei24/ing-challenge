using Bank.Models.Queries;

namespace Bank.Contracts.Queries
{
    public interface IAccountQuery
    {
        Task<List<AccountQueryResponse>> GetAccountsAsync();

        Task<List<AccountQueryResponse>> GetAccountsByClientIdAsync(long clientId);
    }
}

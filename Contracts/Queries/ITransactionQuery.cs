using Bank.Models.Queries;

namespace Bank.Contracts.Queries
{
    public interface ITransactionQuery
    {
        Task<List<TransactionQueryResponse>> GetTransactionsAsync();

        Task<List<TransactionReportQueryResponse>> GetLastMonthTransactionReportAsync(long clientId, long accountId);
    }
}

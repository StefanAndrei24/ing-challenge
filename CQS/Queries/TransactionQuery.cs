using Bank.Contracts.Queries;
using Bank.Infrastructure.DataAccess;
using Bank.Models.Queries;
using Microsoft.EntityFrameworkCore;

namespace Bank.CQS.Queries
{
    public class TransactionQuery : ITransactionQuery
    {
        public TransactionQuery(BankDb bankDb)
        {
            BankDb = bankDb;
        }

        private BankDb BankDb { get; }

        public async Task<List<TransactionReportQueryResponse>> GetLastMonthTransactionReportAsync(long clientId, long accountId)
        {
            var lastMonth = GetLastMonthStartEndDate();

            var transactions = await BankDb.Transactions
                .Include(entity => entity.Category)
                .Include(entity => entity.Account)
                .AsNoTracking()
                .Where(transaction => transaction.Account.ClientId == clientId &&
                       transaction.AccountId == accountId &&
                       transaction.TransactionDate >= lastMonth.firstDay &&
                       transaction.TransactionDate <= lastMonth.lastDay)
                .GroupBy(transaction => transaction.Category.Name)
                .Select(groupedTransaction => new TransactionReportQueryResponse
                {
                    CategoryName = groupedTransaction.Key,
                    totalAmount = groupedTransaction.Sum(transaction => transaction.Amount),
                    Currency = groupedTransaction.First().Account.Name,
                })
                .ToListAsync();

            return transactions;
        }

        public async Task<List<TransactionQueryResponse>> GetTransactionsAsync() =>
            await BankDb.Transactions.AsNoTracking()
            .Select(transaction => new TransactionQueryResponse
            {
                Iban = transaction.Iban,
                TransactionId = transaction.Id,
                Amount = transaction.Amount,
                CategoryId = transaction.CategoryId,
                TransactionDate = transaction.TransactionDate,
            })
            .ToListAsync();

        private (DateTime firstDay, DateTime lastDay) GetLastMonthStartEndDate()
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);

            return (first, last);
        }
    }
}

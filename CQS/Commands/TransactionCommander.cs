using Bank.Contracts.Commands;
using Bank.Infrastructure.DataAccess;
using Bank.Infrastructure.Entities;
using Bank.Models.Commands;

namespace Bank.CQS.Commands
{
    public class TransactionCommander : ITransactionCommander
    {
        public TransactionCommander(BankDb bankDb)
        {
            BankDb = bankDb;
        }

        private BankDb BankDb { get; }

        public async Task<bool> CreateTransactionAsync(TransactionCommandModel transactionCommandModel)
        {
            try
            {
                var transaction = new Transaction
                {
                    Amount = transactionCommandModel.Amount,
                    Iban = transactionCommandModel.Iban,
                    CategoryId = transactionCommandModel.CategoryId,
                    AccountId = transactionCommandModel.AccountId,
                    TransactionDate = transactionCommandModel.TransactionDate,
                    InsertedOn = DateTime.Now
                };

                BankDb.Transactions.Add(transaction);
                return await BankDb.SaveChangesAsync() > 0;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}

using Bank.Models.Commands;

namespace Bank.Contracts.Commands
{
    public interface ITransactionCommander
    {
        Task<bool> CreateTransactionAsync(TransactionCommandModel transactionCommandModel);
    }
}

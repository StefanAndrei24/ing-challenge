using Bank.Models.Commands;

namespace Bank.Contracts.Commands
{
    public interface IAccountCommander
    {
        Task<bool> CreateAccountAsync(AccountCommandModel accountCommandModel);
    }
}

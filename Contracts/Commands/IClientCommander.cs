using Bank.Models.Commands;

namespace Bank.Contracts.Commands
{
    public interface IClientCommander
    {
        Task<bool> CreateClientAsync(ClientCommandModel clientCommandModel);
    }
}

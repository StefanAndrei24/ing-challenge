using Bank.Contracts.Commands;
using Bank.Infrastructure.DataAccess;
using Bank.Infrastructure.Entities;
using Bank.Models.Commands;

namespace Bank.CQS.Commands
{
    public class ClientCommander : IClientCommander
    {
        public ClientCommander(BankDb bankDb)
        {
            BankDb = bankDb;
        }

        public BankDb BankDb { get; }

        public async Task<bool> CreateClientAsync(ClientCommandModel clientCommandModel)
        {
            var client = new Client
            {
                Name = clientCommandModel.Name,
                InsertedOn = DateTime.Now,
            };

            BankDb.Clients.Add(client);
            return await BankDb.SaveChangesAsync() > 0;
        }
    }
}

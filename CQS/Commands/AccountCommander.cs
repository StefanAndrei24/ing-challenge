using Bank.Contracts.Commands;
using Bank.Infrastructure.DataAccess;
using Bank.Infrastructure.Entities;
using Bank.Models.Commands;

namespace Bank.CQS.Commands
{
    public class AccountCommander : IAccountCommander
    {
        public AccountCommander(BankDb bankDb)
        {
            BankDb = bankDb;
        }

        private BankDb BankDb { get; }

        public async Task<bool> CreateAccountAsync(AccountCommandModel accountCommandModel)
        {
            try
            {
                var account = new Account
                {
                    ResourceId = accountCommandModel.ResourceId,
                    Product = accountCommandModel.Product,
                    Iban = accountCommandModel.Iban,
                    Currency = accountCommandModel.Currency,
                    ClientId = accountCommandModel.ClientId,
                    Name = accountCommandModel.Name,
                    InsertedOn = DateTime.Now
                };

                BankDb.Accounts.Add(account);
                return await BankDb.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using Bank.Contracts.Commands;
using Bank.Models.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    public class BankCommandController : ControllerBase
    {
        public BankCommandController(ICommandDecorator commandDecorator)
        {
            CommandDecorator = commandDecorator;
        }

        private ICommandDecorator CommandDecorator { get; }

        [HttpPost("account")]
        public async Task<IActionResult> CreateAccountAsync([FromBody] AccountCommandModel accountCommandModel) =>
            Ok(await CommandDecorator.AccountCommander.CreateAccountAsync(accountCommandModel));

        [HttpPost("client")]
        public async Task<IActionResult> CreateClientAsync([FromBody] ClientCommandModel clientCommandModel) =>
            Ok(await CommandDecorator.ClientCommander.CreateClientAsync(clientCommandModel));

        [HttpPost("transaction")]
        public async Task<IActionResult> CreateTransactionAsync([FromBody] TransactionCommandModel accountCommandModel) =>
            Ok(await CommandDecorator.TransactionCommander.CreateTransactionAsync(accountCommandModel));
    }
}

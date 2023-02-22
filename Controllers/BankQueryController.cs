using Bank.Contracts.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    [ApiController]
    [Route("api")]
    public class BankQueryController : ControllerBase
    {
        public BankQueryController(IQueryDecorator queryDecorator)
        {
            QueryDecorator = queryDecorator;
        }

        private IQueryDecorator QueryDecorator { get; }

        [HttpGet("{clientId}")]
        public async Task<IActionResult> GetAccountsByClientIdAsync(long clientId) =>
            Ok(await QueryDecorator.AccountQuery.GetAccountsByClientIdAsync(clientId));

        [HttpGet("accounts")]
        public async Task<IActionResult> GetAccountsAsync() =>
            Ok(await QueryDecorator.AccountQuery.GetAccountsAsync());

        [HttpGet("transactions")]
        public async Task<IActionResult> GetTransactionsAsync() =>
            Ok(await QueryDecorator.TransactionQuery.GetTransactionsAsync());

        [HttpGet("transactions/report")]
        public async Task<IActionResult> GetTransactionsReportAsync([FromQuery]long clientId, long accountId) =>
            Ok(await QueryDecorator.TransactionQuery.GetLastMonthTransactionReportAsync(clientId, accountId));
    }
}

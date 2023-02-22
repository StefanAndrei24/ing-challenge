using Bank.Contracts.Queries;

namespace Bank.CQS.Queries
{
    public class QueryDecorator : IQueryDecorator
    {
        public QueryDecorator(IAccountQuery accountQuery, ITransactionQuery transactionQuery)
        {
            AccountQuery = accountQuery;
            TransactionQuery = transactionQuery;
        }

        public IAccountQuery AccountQuery { get; }

        public ITransactionQuery TransactionQuery { get; }
    }
}

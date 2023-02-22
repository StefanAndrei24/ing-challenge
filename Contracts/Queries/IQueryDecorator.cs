namespace Bank.Contracts.Queries
{
    public interface IQueryDecorator
    {
        IAccountQuery AccountQuery { get; }

        ITransactionQuery TransactionQuery { get; }
    }
}

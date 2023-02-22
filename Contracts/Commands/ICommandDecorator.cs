namespace Bank.Contracts.Commands
{
    public interface ICommandDecorator
    {
        IAccountCommander AccountCommander { get; }

        IClientCommander ClientCommander { get; }

        ITransactionCommander TransactionCommander { get; }
    }
}

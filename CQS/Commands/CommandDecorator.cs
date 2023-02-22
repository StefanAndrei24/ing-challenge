using Bank.Contracts.Commands;

namespace Bank.CQS.Commands
{
    public class CommandDecorator : ICommandDecorator
    {
        public CommandDecorator(IAccountCommander accountCommander, IClientCommander clientCommander, ITransactionCommander transactionCommander)
        {
            AccountCommander = accountCommander;
            ClientCommander = clientCommander;
            TransactionCommander = transactionCommander;
        }

        public IAccountCommander AccountCommander { get; }

        public IClientCommander ClientCommander { get; }

        public ITransactionCommander TransactionCommander { get; }
    }
}

using Bank.Contracts.Commands;
using Bank.Contracts.Queries;
using Bank.CQS.Commands;
using Bank.CQS.Queries;

namespace Bank.configuration
{
    public static class RegisterDependenciesConfiguration
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            RegisterCommands(services);
            RegisterQueries(services);
        }

        private static void RegisterCommands(IServiceCollection services)
        {
            services.AddScoped<IAccountCommander, AccountCommander>();
            services.AddScoped<IClientCommander, ClientCommander>();
            services.AddScoped<ITransactionCommander, TransactionCommander>();
            services.AddScoped<ICategoryCommander, CategoryCommander>();
            services.AddScoped<ICommandDecorator, CommandDecorator>();
        }

        private static void RegisterQueries(IServiceCollection services)
        {
            services.AddScoped<IAccountQuery, AccountQuery>();
            services.AddScoped<ICategoryQuery, CategoryQuery>();
            services.AddScoped<ITransactionQuery, TransactionQuery>();
            services.AddScoped<IQueryDecorator, QueryDecorator>();
            services.AddScoped<IInterviewAlgoQuery, InterviewAlgoQuery>();
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Bank.Infrastructure.DataAccess.configuration
{
    internal static class ModelBuilderExtension
    {
        internal static ModelBuilder AddEntityConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            return modelBuilder;
        }
    }
}

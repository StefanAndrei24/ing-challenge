using Bank.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Bank.Infrastructure.DataAccess.configuration
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");

            builder.HasMany(client => client.Accounts)
                .WithOne(account => account.Client)
                .HasForeignKey(account => account.ClientId);
        }
    }
}

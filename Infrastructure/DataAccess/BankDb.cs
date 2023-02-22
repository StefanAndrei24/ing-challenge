using Bank.Infrastructure.DataAccess.configuration;
using Bank.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bank.Infrastructure.DataAccess
{
    public class BankDb : DbContext
    {
        protected readonly IConfiguration Configuration;

        public BankDb(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("BankDbConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddEntityConfiguration();
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}

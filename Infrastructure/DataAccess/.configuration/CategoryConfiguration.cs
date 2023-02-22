using Bank.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Bank.Infrastructure.DataAccess.configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasMany(category => category.Transactions)
                .WithOne(transaction => transaction.Category)
                .HasForeignKey(transaction => transaction.CategoryId);

            builder.HasData(GetCategories);
        }

        private static IEnumerable<Category> GetCategories =>
            new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Food",
                },
                new Category
                {
                    Id = 2,
                    Name = "Entertainment",
                },
                new Category
                {
                    Id = 3,
                    Name = "Clothing",
                },
                new Category
                {
                    Id = 4,
                    Name = "Travel",
                },
                new Category
                {
                    Id = 5,
                    Name = "Medical expenses",
                },
            };
    }
}

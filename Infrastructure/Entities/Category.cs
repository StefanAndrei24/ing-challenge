namespace Bank.Infrastructure.Entities
{
    public class Category
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

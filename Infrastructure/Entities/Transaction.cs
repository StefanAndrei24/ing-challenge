namespace Bank.Infrastructure.Entities
{
    public class Transaction : BaseEntity
    {
        public string Iban { get; set; }

        public double Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public long CategoryId { get; set; }

        public Category Category { get; set; }

        public long AccountId { get; set; }

        public Account Account { get; set; }
    }
}
